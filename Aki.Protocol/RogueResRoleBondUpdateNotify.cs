using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001002 RID: 4098
	[NetMessage(EMessageId.RogueResRoleBondUpdateNotify)]
	public sealed class RogueResRoleBondUpdateNotify : IMessage<RogueResRoleBondUpdateNotify>, IMessage, IEquatable<RogueResRoleBondUpdateNotify>, IDeepCloneable<RogueResRoleBondUpdateNotify>, IBufferMessage
	{
		// Token: 0x06015E99 RID: 89753 RVA: 0x0032F6DC File Offset: 0x0032D8DC
		[NullableContext(1)]
		public static RogueResRoleBondUpdateNotify Create()
		{
			return new RogueResRoleBondUpdateNotify();
		}

		// Token: 0x17004936 RID: 18742
		// (get) Token: 0x06015E9A RID: 89754 RVA: 0x0032F6E3 File Offset: 0x0032D8E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004937 RID: 18743
		// (get) Token: 0x06015E9B RID: 89755 RVA: 0x0032F6E6 File Offset: 0x0032D8E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResRoleBondUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06015E9C RID: 89756 RVA: 0x0032F6ED File Offset: 0x0032D8ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResRoleBondUpdateNotify()
		{
		}

		// Token: 0x06015E9D RID: 89757 RVA: 0x0032F700 File Offset: 0x0032D900
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResRoleBondUpdateNotify(RogueResRoleBondUpdateNotify other) : this()
		{
			this.roleBondInfos_ = other.roleBondInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015E9E RID: 89758 RVA: 0x0032F72A File Offset: 0x0032D92A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResRoleBondUpdateNotify Clone()
		{
			return new RogueResRoleBondUpdateNotify(this);
		}

		// Token: 0x17004938 RID: 18744
		// (get) Token: 0x06015E9F RID: 89759 RVA: 0x0032F732 File Offset: 0x0032D932
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoleBondInfo> RoleBondInfos
		{
			get
			{
				return this.roleBondInfos_;
			}
		}

		// Token: 0x06015EA0 RID: 89760 RVA: 0x0032F73A File Offset: 0x0032D93A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResRoleBondUpdateNotify);
		}

		// Token: 0x06015EA1 RID: 89761 RVA: 0x0032F748 File Offset: 0x0032D948
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResRoleBondUpdateNotify other)
		{
			return other != null && (other == this || (this.roleBondInfos_.Equals(other.roleBondInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015EA2 RID: 89762 RVA: 0x0032F77C File Offset: 0x0032D97C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.roleBondInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015EA3 RID: 89763 RVA: 0x0032F7B0 File Offset: 0x0032D9B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015EA4 RID: 89764 RVA: 0x0032F7BD File Offset: 0x0032D9BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015EA5 RID: 89765 RVA: 0x0032F7C6 File Offset: 0x0032D9C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.roleBondInfos_.WriteTo(ref output, RogueResRoleBondUpdateNotify._repeated_roleBondInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015EA6 RID: 89766 RVA: 0x0032F7F0 File Offset: 0x0032D9F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.roleBondInfos_.CalculateSize(RogueResRoleBondUpdateNotify._repeated_roleBondInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015EA7 RID: 89767 RVA: 0x0032F829 File Offset: 0x0032DA29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResRoleBondUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.roleBondInfos_.Add(other.roleBondInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015EA8 RID: 89768 RVA: 0x0032F857 File Offset: 0x0032DA57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015EA9 RID: 89769 RVA: 0x0032F860 File Offset: 0x0032DA60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if ((num & 7U) == 4U)
				{
					return;
				}
				if (num != 42U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.roleBondInfos_.AddEntriesFrom(ref input, RogueResRoleBondUpdateNotify._repeated_roleBondInfos_codec);
				}
			}
		}

		// Token: 0x04008379 RID: 33657
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400837A RID: 33658
		public const int RoleBondInfosFieldNumber = 5;

		// Token: 0x0400837B RID: 33659
		private static readonly FieldCodec<RoleBondInfo> _repeated_roleBondInfos_codec = FieldCodec.ForMessage<RoleBondInfo>(42U, RoleBondInfo.Parser);

		// Token: 0x0400837C RID: 33660
		private readonly RepeatedField<RoleBondInfo> roleBondInfos_ = new RepeatedField<RoleBondInfo>();
	}
}
