using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000A8 RID: 168
	[NetMessage(EMessageId.AddMarkInfoNotify)]
	public sealed class AddMarkInfoNotify : IMessage<AddMarkInfoNotify>, IMessage, IEquatable<AddMarkInfoNotify>, IDeepCloneable<AddMarkInfoNotify>, IBufferMessage
	{
		// Token: 0x06001D12 RID: 7442 RVA: 0x00050510 File Offset: 0x0004E710
		[NullableContext(1)]
		public static AddMarkInfoNotify Create()
		{
			return new AddMarkInfoNotify();
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x06001D13 RID: 7443 RVA: 0x00050517 File Offset: 0x0004E717
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x06001D14 RID: 7444 RVA: 0x0005051A File Offset: 0x0004E71A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AddMarkInfoNotify.Descriptor;
			}
		}

		// Token: 0x06001D15 RID: 7445 RVA: 0x00050521 File Offset: 0x0004E721
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddMarkInfoNotify()
		{
		}

		// Token: 0x06001D16 RID: 7446 RVA: 0x0005052C File Offset: 0x0004E72C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddMarkInfoNotify(AddMarkInfoNotify other) : this()
		{
			this.info_ = ((other.info_ != null) ? other.info_.Clone() : null);
			this.treasureBoxMarkInfo_ = ((other.treasureBoxMarkInfo_ != null) ? other.treasureBoxMarkInfo_.Clone() : null);
			this.attachMark_ = ((other.attachMark_ != null) ? other.attachMark_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001D17 RID: 7447 RVA: 0x000505A4 File Offset: 0x0004E7A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddMarkInfoNotify Clone()
		{
			return new AddMarkInfoNotify(this);
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x06001D18 RID: 7448 RVA: 0x000505AC File Offset: 0x0004E7AC
		// (set) Token: 0x06001D19 RID: 7449 RVA: 0x000505B4 File Offset: 0x0004E7B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MarkPointInfo Info
		{
			get
			{
				return this.info_;
			}
			set
			{
				this.info_ = value;
			}
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x06001D1A RID: 7450 RVA: 0x000505BD File Offset: 0x0004E7BD
		// (set) Token: 0x06001D1B RID: 7451 RVA: 0x000505C5 File Offset: 0x0004E7C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MarkTreasureBoxInfo TreasureBoxMarkInfo
		{
			get
			{
				return this.treasureBoxMarkInfo_;
			}
			set
			{
				this.treasureBoxMarkInfo_ = value;
			}
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x06001D1C RID: 7452 RVA: 0x000505CE File Offset: 0x0004E7CE
		// (set) Token: 0x06001D1D RID: 7453 RVA: 0x000505D6 File Offset: 0x0004E7D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AttachMarkInfo AttachMark
		{
			get
			{
				return this.attachMark_;
			}
			set
			{
				this.attachMark_ = value;
			}
		}

		// Token: 0x06001D1E RID: 7454 RVA: 0x000505DF File Offset: 0x0004E7DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AddMarkInfoNotify);
		}

		// Token: 0x06001D1F RID: 7455 RVA: 0x000505F0 File Offset: 0x0004E7F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AddMarkInfoNotify other)
		{
			return other != null && (other == this || (object.Equals(this.Info, other.Info) && object.Equals(this.TreasureBoxMarkInfo, other.TreasureBoxMarkInfo) && object.Equals(this.AttachMark, other.AttachMark) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001D20 RID: 7456 RVA: 0x00050658 File Offset: 0x0004E858
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.info_ != null)
			{
				num ^= this.Info.GetHashCode();
			}
			if (this.treasureBoxMarkInfo_ != null)
			{
				num ^= this.TreasureBoxMarkInfo.GetHashCode();
			}
			if (this.attachMark_ != null)
			{
				num ^= this.AttachMark.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001D21 RID: 7457 RVA: 0x000506C0 File Offset: 0x0004E8C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001D22 RID: 7458 RVA: 0x000506CD File Offset: 0x0004E8CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001D23 RID: 7459 RVA: 0x000506D8 File Offset: 0x0004E8D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.info_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Info);
			}
			if (this.treasureBoxMarkInfo_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.TreasureBoxMarkInfo);
			}
			if (this.attachMark_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.AttachMark);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001D24 RID: 7460 RVA: 0x00050750 File Offset: 0x0004E950
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.info_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Info);
			}
			if (this.treasureBoxMarkInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TreasureBoxMarkInfo);
			}
			if (this.attachMark_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AttachMark);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001D25 RID: 7461 RVA: 0x000507C0 File Offset: 0x0004E9C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AddMarkInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.info_ != null)
			{
				if (this.info_ == null)
				{
					this.Info = new MarkPointInfo();
				}
				this.Info.MergeFrom(other.Info);
			}
			if (other.treasureBoxMarkInfo_ != null)
			{
				if (this.treasureBoxMarkInfo_ == null)
				{
					this.TreasureBoxMarkInfo = new MarkTreasureBoxInfo();
				}
				this.TreasureBoxMarkInfo.MergeFrom(other.TreasureBoxMarkInfo);
			}
			if (other.attachMark_ != null)
			{
				if (this.attachMark_ == null)
				{
					this.AttachMark = new AttachMarkInfo();
				}
				this.AttachMark.MergeFrom(other.AttachMark);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001D26 RID: 7462 RVA: 0x0005086C File Offset: 0x0004EA6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001D27 RID: 7463 RVA: 0x00050878 File Offset: 0x0004EA78
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
				if (num != 18U)
				{
					if (num != 26U)
					{
						if (num != 114U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.attachMark_ == null)
							{
								this.AttachMark = new AttachMarkInfo();
							}
							input.ReadMessage(this.AttachMark);
						}
					}
					else
					{
						if (this.treasureBoxMarkInfo_ == null)
						{
							this.TreasureBoxMarkInfo = new MarkTreasureBoxInfo();
						}
						input.ReadMessage(this.TreasureBoxMarkInfo);
					}
				}
				else
				{
					if (this.info_ == null)
					{
						this.Info = new MarkPointInfo();
					}
					input.ReadMessage(this.Info);
				}
			}
		}

		// Token: 0x04002354 RID: 9044
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002355 RID: 9045
		public const int InfoFieldNumber = 2;

		// Token: 0x04002356 RID: 9046
		private MarkPointInfo info_;

		// Token: 0x04002357 RID: 9047
		public const int TreasureBoxMarkInfoFieldNumber = 3;

		// Token: 0x04002358 RID: 9048
		private MarkTreasureBoxInfo treasureBoxMarkInfo_;

		// Token: 0x04002359 RID: 9049
		public const int AttachMarkFieldNumber = 14;

		// Token: 0x0400235A RID: 9050
		private AttachMarkInfo attachMark_;
	}
}
