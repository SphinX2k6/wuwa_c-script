using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001371 RID: 4977
	[NetMessage(EMessageId.SwitchRoleNotify)]
	public sealed class SwitchRoleNotify : IMessage<SwitchRoleNotify>, IMessage, IEquatable<SwitchRoleNotify>, IDeepCloneable<SwitchRoleNotify>, IBufferMessage
	{
		// Token: 0x0601A80C RID: 108556 RVA: 0x003DC846 File Offset: 0x003DAA46
		[NullableContext(1)]
		public static SwitchRoleNotify Create()
		{
			return new SwitchRoleNotify();
		}

		// Token: 0x170059B8 RID: 22968
		// (get) Token: 0x0601A80D RID: 108557 RVA: 0x003DC84D File Offset: 0x003DAA4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170059B9 RID: 22969
		// (get) Token: 0x0601A80E RID: 108558 RVA: 0x003DC850 File Offset: 0x003DAA50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SwitchRoleNotify.Descriptor;
			}
		}

		// Token: 0x0601A80F RID: 108559 RVA: 0x003DC857 File Offset: 0x003DAA57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchRoleNotify()
		{
		}

		// Token: 0x0601A810 RID: 108560 RVA: 0x003DC860 File Offset: 0x003DAA60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchRoleNotify(SwitchRoleNotify other) : this()
		{
			this.playerId_ = other.playerId_;
			this.upEntityId_ = other.upEntityId_;
			this.downEntityId_ = other.downEntityId_;
			this.onStageWithoutControl_ = other.onStageWithoutControl_;
			this.transform_ = ((other.transform_ != null) ? other.transform_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A811 RID: 108561 RVA: 0x003DC8D0 File Offset: 0x003DAAD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchRoleNotify Clone()
		{
			return new SwitchRoleNotify(this);
		}

		// Token: 0x170059BA RID: 22970
		// (get) Token: 0x0601A812 RID: 108562 RVA: 0x003DC8D8 File Offset: 0x003DAAD8
		// (set) Token: 0x0601A813 RID: 108563 RVA: 0x003DC8E0 File Offset: 0x003DAAE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerId
		{
			get
			{
				return this.playerId_;
			}
			set
			{
				this.playerId_ = value;
			}
		}

		// Token: 0x170059BB RID: 22971
		// (get) Token: 0x0601A814 RID: 108564 RVA: 0x003DC8E9 File Offset: 0x003DAAE9
		// (set) Token: 0x0601A815 RID: 108565 RVA: 0x003DC8F1 File Offset: 0x003DAAF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long UpEntityId
		{
			get
			{
				return this.upEntityId_;
			}
			set
			{
				this.upEntityId_ = value;
			}
		}

		// Token: 0x170059BC RID: 22972
		// (get) Token: 0x0601A816 RID: 108566 RVA: 0x003DC8FA File Offset: 0x003DAAFA
		// (set) Token: 0x0601A817 RID: 108567 RVA: 0x003DC902 File Offset: 0x003DAB02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long DownEntityId
		{
			get
			{
				return this.downEntityId_;
			}
			set
			{
				this.downEntityId_ = value;
			}
		}

		// Token: 0x170059BD RID: 22973
		// (get) Token: 0x0601A818 RID: 108568 RVA: 0x003DC90B File Offset: 0x003DAB0B
		// (set) Token: 0x0601A819 RID: 108569 RVA: 0x003DC913 File Offset: 0x003DAB13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool OnStageWithoutControl
		{
			get
			{
				return this.onStageWithoutControl_;
			}
			set
			{
				this.onStageWithoutControl_ = value;
			}
		}

		// Token: 0x170059BE RID: 22974
		// (get) Token: 0x0601A81A RID: 108570 RVA: 0x003DC91C File Offset: 0x003DAB1C
		// (set) Token: 0x0601A81B RID: 108571 RVA: 0x003DC924 File Offset: 0x003DAB24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Transform Transform
		{
			get
			{
				return this.transform_;
			}
			set
			{
				this.transform_ = value;
			}
		}

		// Token: 0x0601A81C RID: 108572 RVA: 0x003DC92D File Offset: 0x003DAB2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SwitchRoleNotify);
		}

		// Token: 0x0601A81D RID: 108573 RVA: 0x003DC93C File Offset: 0x003DAB3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SwitchRoleNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.UpEntityId == other.UpEntityId && this.DownEntityId == other.DownEntityId && this.OnStageWithoutControl == other.OnStageWithoutControl && object.Equals(this.Transform, other.Transform) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A81E RID: 108574 RVA: 0x003DC9BC File Offset: 0x003DABBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this.UpEntityId != 0L)
			{
				num ^= this.UpEntityId.GetHashCode();
			}
			if (this.DownEntityId != 0L)
			{
				num ^= this.DownEntityId.GetHashCode();
			}
			if (this.OnStageWithoutControl)
			{
				num ^= this.OnStageWithoutControl.GetHashCode();
			}
			if (this.transform_ != null)
			{
				num ^= this.Transform.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A81F RID: 108575 RVA: 0x003DCA5C File Offset: 0x003DAC5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A820 RID: 108576 RVA: 0x003DCA69 File Offset: 0x003DAC69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A821 RID: 108577 RVA: 0x003DCA74 File Offset: 0x003DAC74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.transform_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Transform);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.PlayerId);
			}
			if (this.DownEntityId != 0L)
			{
				output.WriteRawTag(88);
				output.WriteInt64(this.DownEntityId);
			}
			if (this.UpEntityId != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.UpEntityId);
			}
			if (this.OnStageWithoutControl)
			{
				output.WriteRawTag(112);
				output.WriteBool(this.OnStageWithoutControl);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A822 RID: 108578 RVA: 0x003DCB24 File Offset: 0x003DAD24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this.UpEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.UpEntityId);
			}
			if (this.DownEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.DownEntityId);
			}
			if (this.OnStageWithoutControl)
			{
				num += 2;
			}
			if (this.transform_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Transform);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A823 RID: 108579 RVA: 0x003DCBB8 File Offset: 0x003DADB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SwitchRoleNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			if (other.UpEntityId != 0L)
			{
				this.UpEntityId = other.UpEntityId;
			}
			if (other.DownEntityId != 0L)
			{
				this.DownEntityId = other.DownEntityId;
			}
			if (other.OnStageWithoutControl)
			{
				this.OnStageWithoutControl = other.OnStageWithoutControl;
			}
			if (other.transform_ != null)
			{
				if (this.transform_ == null)
				{
					this.Transform = new Transform();
				}
				this.Transform.MergeFrom(other.Transform);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A824 RID: 108580 RVA: 0x003DCC5C File Offset: 0x003DAE5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A825 RID: 108581 RVA: 0x003DCC68 File Offset: 0x003DAE68
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
				if (num <= 48U)
				{
					if (num == 10U)
					{
						if (this.transform_ == null)
						{
							this.Transform = new Transform();
						}
						input.ReadMessage(this.Transform);
						continue;
					}
					if (num == 48U)
					{
						this.PlayerId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.DownEntityId = input.ReadInt64();
						continue;
					}
					if (num == 96U)
					{
						this.UpEntityId = input.ReadInt64();
						continue;
					}
					if (num == 112U)
					{
						this.OnStageWithoutControl = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009B65 RID: 39781
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009B66 RID: 39782
		public const int PlayerIdFieldNumber = 6;

		// Token: 0x04009B67 RID: 39783
		private int playerId_;

		// Token: 0x04009B68 RID: 39784
		public const int UpEntityIdFieldNumber = 12;

		// Token: 0x04009B69 RID: 39785
		private long upEntityId_;

		// Token: 0x04009B6A RID: 39786
		public const int DownEntityIdFieldNumber = 11;

		// Token: 0x04009B6B RID: 39787
		private long downEntityId_;

		// Token: 0x04009B6C RID: 39788
		public const int OnStageWithoutControlFieldNumber = 14;

		// Token: 0x04009B6D RID: 39789
		private bool onStageWithoutControl_;

		// Token: 0x04009B6E RID: 39790
		public const int TransformFieldNumber = 1;

		// Token: 0x04009B6F RID: 39791
		private Transform transform_;
	}
}
