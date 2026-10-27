using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000642 RID: 1602
	[NetMessage(EMessageId.FragileChangeRequest)]
	public sealed class FragileChangeRequest : IMessage<FragileChangeRequest>, IMessage, IEquatable<FragileChangeRequest>, IDeepCloneable<FragileChangeRequest>, IBufferMessage
	{
		// Token: 0x06009387 RID: 37767 RVA: 0x00164DA7 File Offset: 0x00162FA7
		[NullableContext(1)]
		public static FragileChangeRequest Create()
		{
			return new FragileChangeRequest();
		}

		// Token: 0x17001D5F RID: 7519
		// (get) Token: 0x06009388 RID: 37768 RVA: 0x00164DAE File Offset: 0x00162FAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001D60 RID: 7520
		// (get) Token: 0x06009389 RID: 37769 RVA: 0x00164DB1 File Offset: 0x00162FB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FragileChangeRequest.Descriptor;
			}
		}

		// Token: 0x0600938A RID: 37770 RVA: 0x00164DB8 File Offset: 0x00162FB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FragileChangeRequest()
		{
		}

		// Token: 0x0600938B RID: 37771 RVA: 0x00164DC0 File Offset: 0x00162FC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FragileChangeRequest(FragileChangeRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.flag_ = other.flag_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600938C RID: 37772 RVA: 0x00164DF1 File Offset: 0x00162FF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FragileChangeRequest Clone()
		{
			return new FragileChangeRequest(this);
		}

		// Token: 0x17001D61 RID: 7521
		// (get) Token: 0x0600938D RID: 37773 RVA: 0x00164DF9 File Offset: 0x00162FF9
		// (set) Token: 0x0600938E RID: 37774 RVA: 0x00164E01 File Offset: 0x00163001
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

		// Token: 0x17001D62 RID: 7522
		// (get) Token: 0x0600938F RID: 37775 RVA: 0x00164E0A File Offset: 0x0016300A
		// (set) Token: 0x06009390 RID: 37776 RVA: 0x00164E12 File Offset: 0x00163012
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Flag
		{
			get
			{
				return this.flag_;
			}
			set
			{
				this.flag_ = value;
			}
		}

		// Token: 0x06009391 RID: 37777 RVA: 0x00164E1B File Offset: 0x0016301B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FragileChangeRequest);
		}

		// Token: 0x06009392 RID: 37778 RVA: 0x00164E29 File Offset: 0x00163029
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FragileChangeRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.Flag == other.Flag && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009393 RID: 37779 RVA: 0x00164E68 File Offset: 0x00163068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.Flag)
			{
				num ^= this.Flag.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009394 RID: 37780 RVA: 0x00164EC0 File Offset: 0x001630C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009395 RID: 37781 RVA: 0x00164ECD File Offset: 0x001630CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009396 RID: 37782 RVA: 0x00164ED8 File Offset: 0x001630D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.EntityId);
			}
			if (this.Flag)
			{
				output.WriteRawTag(96);
				output.WriteBool(this.Flag);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009397 RID: 37783 RVA: 0x00164F34 File Offset: 0x00163134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.Flag)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009398 RID: 37784 RVA: 0x00164F80 File Offset: 0x00163180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FragileChangeRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.Flag)
			{
				this.Flag = other.Flag;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009399 RID: 37785 RVA: 0x00164FD0 File Offset: 0x001631D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600939A RID: 37786 RVA: 0x00164FDC File Offset: 0x001631DC
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
				if (num != 80U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Flag = input.ReadBool();
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x040046EC RID: 18156
		private UnknownFieldSet _unknownFields;

		// Token: 0x040046ED RID: 18157
		public const int EntityIdFieldNumber = 10;

		// Token: 0x040046EE RID: 18158
		private long entityId_;

		// Token: 0x040046EF RID: 18159
		public const int FlagFieldNumber = 12;

		// Token: 0x040046F0 RID: 18160
		private bool flag_;
	}
}
