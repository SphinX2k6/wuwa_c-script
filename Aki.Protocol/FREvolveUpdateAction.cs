using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000633 RID: 1587
	public sealed class FREvolveUpdateAction : IMessage<FREvolveUpdateAction>, IMessage, IEquatable<FREvolveUpdateAction>, IDeepCloneable<FREvolveUpdateAction>, IBufferMessage
	{
		// Token: 0x06009295 RID: 37525 RVA: 0x0016308A File Offset: 0x0016128A
		[NullableContext(1)]
		public static FREvolveUpdateAction Create()
		{
			return new FREvolveUpdateAction();
		}

		// Token: 0x17001D29 RID: 7465
		// (get) Token: 0x06009296 RID: 37526 RVA: 0x00163091 File Offset: 0x00161291
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001D2A RID: 7466
		// (get) Token: 0x06009297 RID: 37527 RVA: 0x00163094 File Offset: 0x00161294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FREvolveUpdateAction.Descriptor;
			}
		}

		// Token: 0x06009298 RID: 37528 RVA: 0x0016309B File Offset: 0x0016129B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FREvolveUpdateAction()
		{
		}

		// Token: 0x06009299 RID: 37529 RVA: 0x001630A4 File Offset: 0x001612A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FREvolveUpdateAction(FREvolveUpdateAction other) : this()
		{
			this.targetIncId_ = other.targetIncId_;
			this.newData_ = ((other.newData_ != null) ? other.newData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600929A RID: 37530 RVA: 0x001630F0 File Offset: 0x001612F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FREvolveUpdateAction Clone()
		{
			return new FREvolveUpdateAction(this);
		}

		// Token: 0x17001D2B RID: 7467
		// (get) Token: 0x0600929B RID: 37531 RVA: 0x001630F8 File Offset: 0x001612F8
		// (set) Token: 0x0600929C RID: 37532 RVA: 0x00163100 File Offset: 0x00161300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TargetIncId
		{
			get
			{
				return this.targetIncId_;
			}
			set
			{
				this.targetIncId_ = value;
			}
		}

		// Token: 0x17001D2C RID: 7468
		// (get) Token: 0x0600929D RID: 37533 RVA: 0x00163109 File Offset: 0x00161309
		// (set) Token: 0x0600929E RID: 37534 RVA: 0x00163111 File Offset: 0x00161311
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FREvolveData NewData
		{
			get
			{
				return this.newData_;
			}
			set
			{
				this.newData_ = value;
			}
		}

		// Token: 0x0600929F RID: 37535 RVA: 0x0016311A File Offset: 0x0016131A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FREvolveUpdateAction);
		}

		// Token: 0x060092A0 RID: 37536 RVA: 0x00163128 File Offset: 0x00161328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FREvolveUpdateAction other)
		{
			return other != null && (other == this || (this.TargetIncId == other.TargetIncId && object.Equals(this.NewData, other.NewData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060092A1 RID: 37537 RVA: 0x00163178 File Offset: 0x00161378
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TargetIncId != 0)
			{
				num ^= this.TargetIncId.GetHashCode();
			}
			if (this.newData_ != null)
			{
				num ^= this.NewData.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060092A2 RID: 37538 RVA: 0x001631CD File Offset: 0x001613CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060092A3 RID: 37539 RVA: 0x001631DA File Offset: 0x001613DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060092A4 RID: 37540 RVA: 0x001631E4 File Offset: 0x001613E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TargetIncId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.TargetIncId);
			}
			if (this.newData_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.NewData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060092A5 RID: 37541 RVA: 0x0016323C File Offset: 0x0016143C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TargetIncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TargetIncId);
			}
			if (this.newData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.NewData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060092A6 RID: 37542 RVA: 0x00163294 File Offset: 0x00161494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FREvolveUpdateAction other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TargetIncId != 0)
			{
				this.TargetIncId = other.TargetIncId;
			}
			if (other.newData_ != null)
			{
				if (this.newData_ == null)
				{
					this.NewData = new FREvolveData();
				}
				this.NewData.MergeFrom(other.NewData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060092A7 RID: 37543 RVA: 0x001632FC File Offset: 0x001614FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060092A8 RID: 37544 RVA: 0x00163308 File Offset: 0x00161508
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
				if (num != 8U)
				{
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.newData_ == null)
						{
							this.NewData = new FREvolveData();
						}
						input.ReadMessage(this.NewData);
					}
				}
				else
				{
					this.TargetIncId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004700 RID: 18176
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004701 RID: 18177
		public const int TargetIncIdFieldNumber = 1;

		// Token: 0x04004702 RID: 18178
		private int targetIncId_;

		// Token: 0x04004703 RID: 18179
		public const int NewDataFieldNumber = 2;

		// Token: 0x04004704 RID: 18180
		private FREvolveData newData_;
	}
}
