using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200074C RID: 1868
	public sealed class HarvestPointReward : IMessage<HarvestPointReward>, IMessage, IEquatable<HarvestPointReward>, IDeepCloneable<HarvestPointReward>, IBufferMessage
	{
		// Token: 0x0600A924 RID: 43300 RVA: 0x00196BE4 File Offset: 0x00194DE4
		[NullableContext(1)]
		public static HarvestPointReward Create()
		{
			return new HarvestPointReward();
		}

		// Token: 0x17002204 RID: 8708
		// (get) Token: 0x0600A925 RID: 43301 RVA: 0x00196BEB File Offset: 0x00194DEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HarvestPointReward> Parser
		{
			get
			{
				return HarvestPointReward._parser;
			}
		}

		// Token: 0x17002205 RID: 8709
		// (get) Token: 0x0600A926 RID: 43302 RVA: 0x00196BF2 File Offset: 0x00194DF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002206 RID: 8710
		// (get) Token: 0x0600A927 RID: 43303 RVA: 0x00196BF5 File Offset: 0x00194DF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HarvestPointReward.Descriptor;
			}
		}

		// Token: 0x0600A928 RID: 43304 RVA: 0x00196BFC File Offset: 0x00194DFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HarvestPointReward()
		{
		}

		// Token: 0x0600A929 RID: 43305 RVA: 0x00196C04 File Offset: 0x00194E04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HarvestPointReward(HarvestPointReward other) : this()
		{
			this.id_ = other.id_;
			this.state_ = other.state_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A92A RID: 43306 RVA: 0x00196C35 File Offset: 0x00194E35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HarvestPointReward Clone()
		{
			return new HarvestPointReward(this);
		}

		// Token: 0x17002207 RID: 8711
		// (get) Token: 0x0600A92B RID: 43307 RVA: 0x00196C3D File Offset: 0x00194E3D
		// (set) Token: 0x0600A92C RID: 43308 RVA: 0x00196C45 File Offset: 0x00194E45
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

		// Token: 0x17002208 RID: 8712
		// (get) Token: 0x0600A92D RID: 43309 RVA: 0x00196C4E File Offset: 0x00194E4E
		// (set) Token: 0x0600A92E RID: 43310 RVA: 0x00196C56 File Offset: 0x00194E56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SignState State
		{
			get
			{
				return this.state_;
			}
			set
			{
				this.state_ = value;
			}
		}

		// Token: 0x0600A92F RID: 43311 RVA: 0x00196C5F File Offset: 0x00194E5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HarvestPointReward);
		}

		// Token: 0x0600A930 RID: 43312 RVA: 0x00196C6D File Offset: 0x00194E6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HarvestPointReward other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.State == other.State && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A931 RID: 43313 RVA: 0x00196CAC File Offset: 0x00194EAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.State != SignState.Lock)
			{
				num ^= this.State.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A932 RID: 43314 RVA: 0x00196D0A File Offset: 0x00194F0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A933 RID: 43315 RVA: 0x00196D17 File Offset: 0x00194F17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A934 RID: 43316 RVA: 0x00196D20 File Offset: 0x00194F20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.State != SignState.Lock)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.State);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A935 RID: 43317 RVA: 0x00196D78 File Offset: 0x00194F78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.State != SignState.Lock)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.State);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A936 RID: 43318 RVA: 0x00196DD0 File Offset: 0x00194FD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HarvestPointReward other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.State != SignState.Lock)
			{
				this.State = other.State;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A937 RID: 43319 RVA: 0x00196E20 File Offset: 0x00195020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A938 RID: 43320 RVA: 0x00196E2C File Offset: 0x0019502C
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
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.State = (SignState)input.ReadEnum();
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004D09 RID: 19721
		private static readonly MessageParser<HarvestPointReward> _parser = new MessageParser<HarvestPointReward>(() => new HarvestPointReward());

		// Token: 0x04004D0A RID: 19722
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004D0B RID: 19723
		public const int IdFieldNumber = 1;

		// Token: 0x04004D0C RID: 19724
		private int id_;

		// Token: 0x04004D0D RID: 19725
		public const int StateFieldNumber = 2;

		// Token: 0x04004D0E RID: 19726
		private SignState state_;
	}
}
