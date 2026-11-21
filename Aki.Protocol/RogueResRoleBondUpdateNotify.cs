using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FF2 RID: 4082
	[NetMessage(EMessageId.RogueResRoleBondUpdateNotify)]
	public sealed class RogueResRoleBondUpdateNotify : IMessage<RogueResRoleBondUpdateNotify>, IMessage, IEquatable<RogueResRoleBondUpdateNotify>, IDeepCloneable<RogueResRoleBondUpdateNotify>, IBufferMessage
	{
		// Token: 0x06015DB4 RID: 89524 RVA: 0x0032E020 File Offset: 0x0032C220
		[NullableContext(1)]
		public static RogueResRoleBondUpdateNotify Create()
		{
			return new RogueResRoleBondUpdateNotify();
		}

		// Token: 0x1700490C RID: 18700
		// (get) Token: 0x06015DB5 RID: 89525 RVA: 0x0032E027 File Offset: 0x0032C227
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700490D RID: 18701
		// (get) Token: 0x06015DB6 RID: 89526 RVA: 0x0032E02A File Offset: 0x0032C22A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResRoleBondUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06015DB7 RID: 89527 RVA: 0x0032E031 File Offset: 0x0032C231
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResRoleBondUpdateNotify()
		{
		}

		// Token: 0x06015DB8 RID: 89528 RVA: 0x0032E044 File Offset: 0x0032C244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResRoleBondUpdateNotify(RogueResRoleBondUpdateNotify other) : this()
		{
			this.roleBondInfos_ = other.roleBondInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015DB9 RID: 89529 RVA: 0x0032E06E File Offset: 0x0032C26E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResRoleBondUpdateNotify Clone()
		{
			return new RogueResRoleBondUpdateNotify(this);
		}

		// Token: 0x1700490E RID: 18702
		// (get) Token: 0x06015DBA RID: 89530 RVA: 0x0032E076 File Offset: 0x0032C276
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoleBondInfo> RoleBondInfos
		{
			get
			{
				return this.roleBondInfos_;
			}
		}

		// Token: 0x06015DBB RID: 89531 RVA: 0x0032E07E File Offset: 0x0032C27E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResRoleBondUpdateNotify);
		}

		// Token: 0x06015DBC RID: 89532 RVA: 0x0032E08C File Offset: 0x0032C28C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResRoleBondUpdateNotify other)
		{
			return other != null && (other == this || (this.roleBondInfos_.Equals(other.roleBondInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015DBD RID: 89533 RVA: 0x0032E0C0 File Offset: 0x0032C2C0
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

		// Token: 0x06015DBE RID: 89534 RVA: 0x0032E0F4 File Offset: 0x0032C2F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015DBF RID: 89535 RVA: 0x0032E101 File Offset: 0x0032C301
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015DC0 RID: 89536 RVA: 0x0032E10A File Offset: 0x0032C30A
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

		// Token: 0x06015DC1 RID: 89537 RVA: 0x0032E134 File Offset: 0x0032C334
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

		// Token: 0x06015DC2 RID: 89538 RVA: 0x0032E16D File Offset: 0x0032C36D
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

		// Token: 0x06015DC3 RID: 89539 RVA: 0x0032E19B File Offset: 0x0032C39B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015DC4 RID: 89540 RVA: 0x0032E1A4 File Offset: 0x0032C3A4
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
				if (num != 90U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.roleBondInfos_.AddEntriesFrom(ref input, RogueResRoleBondUpdateNotify._repeated_roleBondInfos_codec);
				}
			}
		}

		// Token: 0x040083A3 RID: 33699
		private UnknownFieldSet _unknownFields;

		// Token: 0x040083A4 RID: 33700
		public const int RoleBondInfosFieldNumber = 11;

		// Token: 0x040083A5 RID: 33701
		private static readonly FieldCodec<RoleBondInfo> _repeated_roleBondInfos_codec = FieldCodec.ForMessage<RoleBondInfo>(90U, RoleBondInfo.Parser);

		// Token: 0x040083A6 RID: 33702
		private readonly RepeatedField<RoleBondInfo> roleBondInfos_ = new RepeatedField<RoleBondInfo>();
	}
}
