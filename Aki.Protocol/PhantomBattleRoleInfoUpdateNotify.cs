using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CA9 RID: 3241
	[NetMessage(EMessageId.PhantomBattleRoleInfoUpdateNotify)]
	public sealed class PhantomBattleRoleInfoUpdateNotify : IMessage<PhantomBattleRoleInfoUpdateNotify>, IMessage, IEquatable<PhantomBattleRoleInfoUpdateNotify>, IDeepCloneable<PhantomBattleRoleInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x06011901 RID: 71937 RVA: 0x00292AA6 File Offset: 0x00290CA6
		[NullableContext(1)]
		public static PhantomBattleRoleInfoUpdateNotify Create()
		{
			return new PhantomBattleRoleInfoUpdateNotify();
		}

		// Token: 0x17003A32 RID: 14898
		// (get) Token: 0x06011902 RID: 71938 RVA: 0x00292AAD File Offset: 0x00290CAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003A33 RID: 14899
		// (get) Token: 0x06011903 RID: 71939 RVA: 0x00292AB0 File Offset: 0x00290CB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleRoleInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06011904 RID: 71940 RVA: 0x00292AB7 File Offset: 0x00290CB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleRoleInfoUpdateNotify()
		{
		}

		// Token: 0x06011905 RID: 71941 RVA: 0x00292ACA File Offset: 0x00290CCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleRoleInfoUpdateNotify(PhantomBattleRoleInfoUpdateNotify other) : this()
		{
			this.phantomBattleRoleInfos_ = other.phantomBattleRoleInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011906 RID: 71942 RVA: 0x00292AF4 File Offset: 0x00290CF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleRoleInfoUpdateNotify Clone()
		{
			return new PhantomBattleRoleInfoUpdateNotify(this);
		}

		// Token: 0x17003A34 RID: 14900
		// (get) Token: 0x06011907 RID: 71943 RVA: 0x00292AFC File Offset: 0x00290CFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleRoleInfo> PhantomBattleRoleInfos
		{
			get
			{
				return this.phantomBattleRoleInfos_;
			}
		}

		// Token: 0x06011908 RID: 71944 RVA: 0x00292B04 File Offset: 0x00290D04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleRoleInfoUpdateNotify);
		}

		// Token: 0x06011909 RID: 71945 RVA: 0x00292B12 File Offset: 0x00290D12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleRoleInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.phantomBattleRoleInfos_.Equals(other.phantomBattleRoleInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601190A RID: 71946 RVA: 0x00292B48 File Offset: 0x00290D48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.phantomBattleRoleInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601190B RID: 71947 RVA: 0x00292B7C File Offset: 0x00290D7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601190C RID: 71948 RVA: 0x00292B89 File Offset: 0x00290D89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601190D RID: 71949 RVA: 0x00292B92 File Offset: 0x00290D92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.phantomBattleRoleInfos_.WriteTo(ref output, PhantomBattleRoleInfoUpdateNotify._repeated_phantomBattleRoleInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601190E RID: 71950 RVA: 0x00292BBC File Offset: 0x00290DBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.phantomBattleRoleInfos_.CalculateSize(PhantomBattleRoleInfoUpdateNotify._repeated_phantomBattleRoleInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601190F RID: 71951 RVA: 0x00292BF5 File Offset: 0x00290DF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleRoleInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.phantomBattleRoleInfos_.Add(other.phantomBattleRoleInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011910 RID: 71952 RVA: 0x00292C23 File Offset: 0x00290E23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011911 RID: 71953 RVA: 0x00292C2C File Offset: 0x00290E2C
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
					this.phantomBattleRoleInfos_.AddEntriesFrom(ref input, PhantomBattleRoleInfoUpdateNotify._repeated_phantomBattleRoleInfos_codec);
				}
			}
		}

		// Token: 0x04006EB6 RID: 28342
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006EB7 RID: 28343
		public const int PhantomBattleRoleInfosFieldNumber = 5;

		// Token: 0x04006EB8 RID: 28344
		private static readonly FieldCodec<PhantomBattleRoleInfo> _repeated_phantomBattleRoleInfos_codec = FieldCodec.ForMessage<PhantomBattleRoleInfo>(42U, PhantomBattleRoleInfo.Parser);

		// Token: 0x04006EB9 RID: 28345
		private readonly RepeatedField<PhantomBattleRoleInfo> phantomBattleRoleInfos_ = new RepeatedField<PhantomBattleRoleInfo>();
	}
}
