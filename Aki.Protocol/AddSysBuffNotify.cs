using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000AF RID: 175
	[NetMessage(EMessageId.AddSysBuffNotify)]
	public sealed class AddSysBuffNotify : IMessage<AddSysBuffNotify>, IMessage, IEquatable<AddSysBuffNotify>, IDeepCloneable<AddSysBuffNotify>, IBufferMessage
	{
		// Token: 0x06001D67 RID: 7527 RVA: 0x00050E3E File Offset: 0x0004F03E
		[NullableContext(1)]
		public static AddSysBuffNotify Create()
		{
			return new AddSysBuffNotify();
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x06001D68 RID: 7528 RVA: 0x00050E45 File Offset: 0x0004F045
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x06001D69 RID: 7529 RVA: 0x00050E48 File Offset: 0x0004F048
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AddSysBuffNotify.Descriptor;
			}
		}

		// Token: 0x06001D6A RID: 7530 RVA: 0x00050E4F File Offset: 0x0004F04F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddSysBuffNotify()
		{
		}

		// Token: 0x06001D6B RID: 7531 RVA: 0x00050E62 File Offset: 0x0004F062
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddSysBuffNotify(AddSysBuffNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.buffInfos_ = other.buffInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001D6C RID: 7532 RVA: 0x00050E98 File Offset: 0x0004F098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddSysBuffNotify Clone()
		{
			return new AddSysBuffNotify(this);
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x06001D6D RID: 7533 RVA: 0x00050EA0 File Offset: 0x0004F0A0
		// (set) Token: 0x06001D6E RID: 7534 RVA: 0x00050EA8 File Offset: 0x0004F0A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x06001D6F RID: 7535 RVA: 0x00050EB1 File Offset: 0x0004F0B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SysBuffInformation> BuffInfos
		{
			get
			{
				return this.buffInfos_;
			}
		}

		// Token: 0x06001D70 RID: 7536 RVA: 0x00050EB9 File Offset: 0x0004F0B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AddSysBuffNotify);
		}

		// Token: 0x06001D71 RID: 7537 RVA: 0x00050EC8 File Offset: 0x0004F0C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AddSysBuffNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.buffInfos_.Equals(other.buffInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001D72 RID: 7538 RVA: 0x00050F18 File Offset: 0x0004F118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			num ^= this.buffInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001D73 RID: 7539 RVA: 0x00050F65 File Offset: 0x0004F165
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001D74 RID: 7540 RVA: 0x00050F72 File Offset: 0x0004F172
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001D75 RID: 7541 RVA: 0x00050F7C File Offset: 0x0004F17C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.EntityId);
			}
			this.buffInfos_.WriteTo(ref output, AddSysBuffNotify._repeated_buffInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001D76 RID: 7542 RVA: 0x00050FCC File Offset: 0x0004F1CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			num += this.buffInfos_.CalculateSize(AddSysBuffNotify._repeated_buffInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001D77 RID: 7543 RVA: 0x00051020 File Offset: 0x0004F220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AddSysBuffNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			this.buffInfos_.Add(other.buffInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001D78 RID: 7544 RVA: 0x0005106D File Offset: 0x0004F26D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001D79 RID: 7545 RVA: 0x00051078 File Offset: 0x0004F278
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
				if (num != 64U)
				{
					if (num != 74U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.buffInfos_.AddEntriesFrom(ref input, AddSysBuffNotify._repeated_buffInfos_codec);
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04002319 RID: 8985
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400231A RID: 8986
		public const int EntityIdFieldNumber = 8;

		// Token: 0x0400231B RID: 8987
		private long entityId_;

		// Token: 0x0400231C RID: 8988
		public const int BuffInfosFieldNumber = 9;

		// Token: 0x0400231D RID: 8989
		private static readonly FieldCodec<SysBuffInformation> _repeated_buffInfos_codec = FieldCodec.ForMessage<SysBuffInformation>(74U, SysBuffInformation.Parser);

		// Token: 0x0400231E RID: 8990
		private readonly RepeatedField<SysBuffInformation> buffInfos_ = new RepeatedField<SysBuffInformation>();
	}
}
