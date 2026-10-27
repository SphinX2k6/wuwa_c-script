using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001259 RID: 4697
	[NetMessage(EMessageId.SneakFinishRequest)]
	public sealed class SneakFinishRequest : IMessage<SneakFinishRequest>, IMessage, IEquatable<SneakFinishRequest>, IDeepCloneable<SneakFinishRequest>, IBufferMessage
	{
		// Token: 0x0601906B RID: 102507 RVA: 0x003A435B File Offset: 0x003A255B
		[NullableContext(1)]
		public static SneakFinishRequest Create()
		{
			return new SneakFinishRequest();
		}

		// Token: 0x17005468 RID: 21608
		// (get) Token: 0x0601906C RID: 102508 RVA: 0x003A4362 File Offset: 0x003A2562
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005469 RID: 21609
		// (get) Token: 0x0601906D RID: 102509 RVA: 0x003A4365 File Offset: 0x003A2565
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SneakFinishRequest.Descriptor;
			}
		}

		// Token: 0x0601906E RID: 102510 RVA: 0x003A436C File Offset: 0x003A256C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SneakFinishRequest()
		{
		}

		// Token: 0x0601906F RID: 102511 RVA: 0x003A4374 File Offset: 0x003A2574
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SneakFinishRequest(SneakFinishRequest other) : this()
		{
			this.sneakId_ = other.sneakId_;
			this.finishType_ = other.finishType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019070 RID: 102512 RVA: 0x003A43A5 File Offset: 0x003A25A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SneakFinishRequest Clone()
		{
			return new SneakFinishRequest(this);
		}

		// Token: 0x1700546A RID: 21610
		// (get) Token: 0x06019071 RID: 102513 RVA: 0x003A43AD File Offset: 0x003A25AD
		// (set) Token: 0x06019072 RID: 102514 RVA: 0x003A43B5 File Offset: 0x003A25B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SneakId
		{
			get
			{
				return this.sneakId_;
			}
			set
			{
				this.sneakId_ = value;
			}
		}

		// Token: 0x1700546B RID: 21611
		// (get) Token: 0x06019073 RID: 102515 RVA: 0x003A43BE File Offset: 0x003A25BE
		// (set) Token: 0x06019074 RID: 102516 RVA: 0x003A43C6 File Offset: 0x003A25C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SneakFinishType FinishType
		{
			get
			{
				return this.finishType_;
			}
			set
			{
				this.finishType_ = value;
			}
		}

		// Token: 0x06019075 RID: 102517 RVA: 0x003A43CF File Offset: 0x003A25CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SneakFinishRequest);
		}

		// Token: 0x06019076 RID: 102518 RVA: 0x003A43DD File Offset: 0x003A25DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SneakFinishRequest other)
		{
			return other != null && (other == this || (this.SneakId == other.SneakId && this.FinishType == other.FinishType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019077 RID: 102519 RVA: 0x003A441C File Offset: 0x003A261C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SneakId != 0)
			{
				num ^= this.SneakId.GetHashCode();
			}
			if (this.FinishType != SneakFinishType.SneakSuccess)
			{
				num ^= this.FinishType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019078 RID: 102520 RVA: 0x003A447A File Offset: 0x003A267A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019079 RID: 102521 RVA: 0x003A4487 File Offset: 0x003A2687
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601907A RID: 102522 RVA: 0x003A4490 File Offset: 0x003A2690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SneakId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.SneakId);
			}
			if (this.FinishType != SneakFinishType.SneakSuccess)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.FinishType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601907B RID: 102523 RVA: 0x003A44EC File Offset: 0x003A26EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SneakId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SneakId);
			}
			if (this.FinishType != SneakFinishType.SneakSuccess)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.FinishType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601907C RID: 102524 RVA: 0x003A4544 File Offset: 0x003A2744
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SneakFinishRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SneakId != 0)
			{
				this.SneakId = other.SneakId;
			}
			if (other.FinishType != SneakFinishType.SneakSuccess)
			{
				this.FinishType = other.FinishType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601907D RID: 102525 RVA: 0x003A4594 File Offset: 0x003A2794
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601907E RID: 102526 RVA: 0x003A45A0 File Offset: 0x003A27A0
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
				if (num != 96U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.FinishType = (SneakFinishType)input.ReadEnum();
					}
				}
				else
				{
					this.SneakId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009379 RID: 37753
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400937A RID: 37754
		public const int SneakIdFieldNumber = 12;

		// Token: 0x0400937B RID: 37755
		private int sneakId_;

		// Token: 0x0400937C RID: 37756
		public const int FinishTypeFieldNumber = 14;

		// Token: 0x0400937D RID: 37757
		private SneakFinishType finishType_;
	}
}
