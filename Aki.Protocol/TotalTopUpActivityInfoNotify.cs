using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013FE RID: 5118
	[NetMessage(EMessageId.TotalTopUpActivityInfoNotify)]
	public sealed class TotalTopUpActivityInfoNotify : IMessage<TotalTopUpActivityInfoNotify>, IMessage, IEquatable<TotalTopUpActivityInfoNotify>, IDeepCloneable<TotalTopUpActivityInfoNotify>, IBufferMessage
	{
		// Token: 0x0601B360 RID: 111456 RVA: 0x003F56F3 File Offset: 0x003F38F3
		[NullableContext(1)]
		public static TotalTopUpActivityInfoNotify Create()
		{
			return new TotalTopUpActivityInfoNotify();
		}

		// Token: 0x17005C1C RID: 23580
		// (get) Token: 0x0601B361 RID: 111457 RVA: 0x003F56FA File Offset: 0x003F38FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005C1D RID: 23581
		// (get) Token: 0x0601B362 RID: 111458 RVA: 0x003F56FD File Offset: 0x003F38FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TotalTopUpActivityInfoNotify.Descriptor;
			}
		}

		// Token: 0x0601B363 RID: 111459 RVA: 0x003F5704 File Offset: 0x003F3904
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TotalTopUpActivityInfoNotify()
		{
		}

		// Token: 0x0601B364 RID: 111460 RVA: 0x003F570C File Offset: 0x003F390C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TotalTopUpActivityInfoNotify(TotalTopUpActivityInfoNotify other) : this()
		{
			this.totalTopUpActivityInfo_ = ((other.totalTopUpActivityInfo_ != null) ? other.totalTopUpActivityInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B365 RID: 111461 RVA: 0x003F5741 File Offset: 0x003F3941
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TotalTopUpActivityInfoNotify Clone()
		{
			return new TotalTopUpActivityInfoNotify(this);
		}

		// Token: 0x17005C1E RID: 23582
		// (get) Token: 0x0601B366 RID: 111462 RVA: 0x003F5749 File Offset: 0x003F3949
		// (set) Token: 0x0601B367 RID: 111463 RVA: 0x003F5751 File Offset: 0x003F3951
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TotalTopUpActivityInfo TotalTopUpActivityInfo
		{
			get
			{
				return this.totalTopUpActivityInfo_;
			}
			set
			{
				this.totalTopUpActivityInfo_ = value;
			}
		}

		// Token: 0x0601B368 RID: 111464 RVA: 0x003F575A File Offset: 0x003F395A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TotalTopUpActivityInfoNotify);
		}

		// Token: 0x0601B369 RID: 111465 RVA: 0x003F5768 File Offset: 0x003F3968
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TotalTopUpActivityInfoNotify other)
		{
			return other != null && (other == this || (object.Equals(this.TotalTopUpActivityInfo, other.TotalTopUpActivityInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B36A RID: 111466 RVA: 0x003F579C File Offset: 0x003F399C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.totalTopUpActivityInfo_ != null)
			{
				num ^= this.TotalTopUpActivityInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B36B RID: 111467 RVA: 0x003F57D8 File Offset: 0x003F39D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B36C RID: 111468 RVA: 0x003F57E5 File Offset: 0x003F39E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B36D RID: 111469 RVA: 0x003F57EE File Offset: 0x003F39EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.totalTopUpActivityInfo_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.TotalTopUpActivityInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B36E RID: 111470 RVA: 0x003F5820 File Offset: 0x003F3A20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.totalTopUpActivityInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TotalTopUpActivityInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B36F RID: 111471 RVA: 0x003F5860 File Offset: 0x003F3A60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TotalTopUpActivityInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.totalTopUpActivityInfo_ != null)
			{
				if (this.totalTopUpActivityInfo_ == null)
				{
					this.TotalTopUpActivityInfo = new TotalTopUpActivityInfo();
				}
				this.TotalTopUpActivityInfo.MergeFrom(other.TotalTopUpActivityInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B370 RID: 111472 RVA: 0x003F58B4 File Offset: 0x003F3AB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B371 RID: 111473 RVA: 0x003F58C0 File Offset: 0x003F3AC0
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
				if (num != 26U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.totalTopUpActivityInfo_ == null)
					{
						this.TotalTopUpActivityInfo = new TotalTopUpActivityInfo();
					}
					input.ReadMessage(this.TotalTopUpActivityInfo);
				}
			}
		}

		// Token: 0x04009EA7 RID: 40615
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009EA8 RID: 40616
		public const int TotalTopUpActivityInfoFieldNumber = 3;

		// Token: 0x04009EA9 RID: 40617
		private TotalTopUpActivityInfo totalTopUpActivityInfo_;
	}
}
