using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BDE RID: 3038
	[NetMessage(EMessageId.PayGiftRequest)]
	public sealed class PayGiftRequest : IMessage<PayGiftRequest>, IMessage, IEquatable<PayGiftRequest>, IDeepCloneable<PayGiftRequest>, IBufferMessage
	{
		// Token: 0x0601075E RID: 67422 RVA: 0x00266F6F File Offset: 0x0026516F
		[NullableContext(1)]
		public static PayGiftRequest Create()
		{
			return new PayGiftRequest();
		}

		// Token: 0x1700360A RID: 13834
		// (get) Token: 0x0601075F RID: 67423 RVA: 0x00266F76 File Offset: 0x00265176
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700360B RID: 13835
		// (get) Token: 0x06010760 RID: 67424 RVA: 0x00266F79 File Offset: 0x00265179
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PayGiftRequest.Descriptor;
			}
		}

		// Token: 0x06010761 RID: 67425 RVA: 0x00266F80 File Offset: 0x00265180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayGiftRequest()
		{
		}

		// Token: 0x06010762 RID: 67426 RVA: 0x00266F93 File Offset: 0x00265193
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayGiftRequest(PayGiftRequest other) : this()
		{
			this.id_ = other.id_;
			this.version_ = other.version_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010763 RID: 67427 RVA: 0x00266FC4 File Offset: 0x002651C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayGiftRequest Clone()
		{
			return new PayGiftRequest(this);
		}

		// Token: 0x1700360C RID: 13836
		// (get) Token: 0x06010764 RID: 67428 RVA: 0x00266FCC File Offset: 0x002651CC
		// (set) Token: 0x06010765 RID: 67429 RVA: 0x00266FD4 File Offset: 0x002651D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x1700360D RID: 13837
		// (get) Token: 0x06010766 RID: 67430 RVA: 0x00266FDD File Offset: 0x002651DD
		// (set) Token: 0x06010767 RID: 67431 RVA: 0x00266FE5 File Offset: 0x002651E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Version
		{
			get
			{
				return this.version_;
			}
			set
			{
				this.version_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x06010768 RID: 67432 RVA: 0x00266FF8 File Offset: 0x002651F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PayGiftRequest);
		}

		// Token: 0x06010769 RID: 67433 RVA: 0x00267008 File Offset: 0x00265208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PayGiftRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && !(this.Version != other.Version) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601076A RID: 67434 RVA: 0x00267058 File Offset: 0x00265258
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Version.Length != 0)
			{
				num ^= this.Version.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601076B RID: 67435 RVA: 0x002670B2 File Offset: 0x002652B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601076C RID: 67436 RVA: 0x002670BF File Offset: 0x002652BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601076D RID: 67437 RVA: 0x002670C8 File Offset: 0x002652C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.Id);
			}
			if (this.Version.Length != 0)
			{
				output.WriteRawTag(74);
				output.WriteString(this.Version);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601076E RID: 67438 RVA: 0x00267128 File Offset: 0x00265328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.Version.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Version);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601076F RID: 67439 RVA: 0x00267184 File Offset: 0x00265384
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PayGiftRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Version.Length != 0)
			{
				this.Version = other.Version;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010770 RID: 67440 RVA: 0x002671D9 File Offset: 0x002653D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010771 RID: 67441 RVA: 0x002671E4 File Offset: 0x002653E4
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
						this.Version = input.ReadString();
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006877 RID: 26743
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006878 RID: 26744
		public const int IdFieldNumber = 8;

		// Token: 0x04006879 RID: 26745
		private int id_;

		// Token: 0x0400687A RID: 26746
		public const int VersionFieldNumber = 9;

		// Token: 0x0400687B RID: 26747
		private string version_ = "";
	}
}
