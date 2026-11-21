using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000B0 RID: 176
	[NetMessage(EMessageId.AddSysBuffNotify)]
	public sealed class AddSysBuffNotify : IMessage<AddSysBuffNotify>, IMessage, IEquatable<AddSysBuffNotify>, IDeepCloneable<AddSysBuffNotify>, IBufferMessage
	{
		// Token: 0x06001DB0 RID: 7600 RVA: 0x00051AF2 File Offset: 0x0004FCF2
		[NullableContext(1)]
		public static AddSysBuffNotify Create()
		{
			return new AddSysBuffNotify();
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x06001DB1 RID: 7601 RVA: 0x00051AF9 File Offset: 0x0004FCF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x06001DB2 RID: 7602 RVA: 0x00051AFC File Offset: 0x0004FCFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AddSysBuffNotify.Descriptor;
			}
		}

		// Token: 0x06001DB3 RID: 7603 RVA: 0x00051B03 File Offset: 0x0004FD03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddSysBuffNotify()
		{
		}

		// Token: 0x06001DB4 RID: 7604 RVA: 0x00051B16 File Offset: 0x0004FD16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddSysBuffNotify(AddSysBuffNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.buffInfos_ = other.buffInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001DB5 RID: 7605 RVA: 0x00051B4C File Offset: 0x0004FD4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddSysBuffNotify Clone()
		{
			return new AddSysBuffNotify(this);
		}

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x06001DB6 RID: 7606 RVA: 0x00051B54 File Offset: 0x0004FD54
		// (set) Token: 0x06001DB7 RID: 7607 RVA: 0x00051B5C File Offset: 0x0004FD5C
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

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x06001DB8 RID: 7608 RVA: 0x00051B65 File Offset: 0x0004FD65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SysBuffInformation> BuffInfos
		{
			get
			{
				return this.buffInfos_;
			}
		}

		// Token: 0x06001DB9 RID: 7609 RVA: 0x00051B6D File Offset: 0x0004FD6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AddSysBuffNotify);
		}

		// Token: 0x06001DBA RID: 7610 RVA: 0x00051B7C File Offset: 0x0004FD7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AddSysBuffNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.buffInfos_.Equals(other.buffInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001DBB RID: 7611 RVA: 0x00051BCC File Offset: 0x0004FDCC
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

		// Token: 0x06001DBC RID: 7612 RVA: 0x00051C19 File Offset: 0x0004FE19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001DBD RID: 7613 RVA: 0x00051C26 File Offset: 0x0004FE26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001DBE RID: 7614 RVA: 0x00051C30 File Offset: 0x0004FE30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.buffInfos_.WriteTo(ref output, AddSysBuffNotify._repeated_buffInfos_codec);
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(104);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001DBF RID: 7615 RVA: 0x00051C80 File Offset: 0x0004FE80
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

		// Token: 0x06001DC0 RID: 7616 RVA: 0x00051CD4 File Offset: 0x0004FED4
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

		// Token: 0x06001DC1 RID: 7617 RVA: 0x00051D21 File Offset: 0x0004FF21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001DC2 RID: 7618 RVA: 0x00051D2C File Offset: 0x0004FF2C
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
				if (num != 34U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.EntityId = input.ReadInt64();
					}
				}
				else
				{
					this.buffInfos_.AddEntriesFrom(ref input, AddSysBuffNotify._repeated_buffInfos_codec);
				}
			}
		}

		// Token: 0x0400237C RID: 9084
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400237D RID: 9085
		public const int EntityIdFieldNumber = 13;

		// Token: 0x0400237E RID: 9086
		private long entityId_;

		// Token: 0x0400237F RID: 9087
		public const int BuffInfosFieldNumber = 4;

		// Token: 0x04002380 RID: 9088
		private static readonly FieldCodec<SysBuffInformation> _repeated_buffInfos_codec = FieldCodec.ForMessage<SysBuffInformation>(34U, SysBuffInformation.Parser);

		// Token: 0x04002381 RID: 9089
		private readonly RepeatedField<SysBuffInformation> buffInfos_ = new RepeatedField<SysBuffInformation>();
	}
}
