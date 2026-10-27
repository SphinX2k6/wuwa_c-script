using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013EC RID: 5100
	public sealed class TrackMoonTarget : IMessage<TrackMoonTarget>, IMessage, IEquatable<TrackMoonTarget>, IDeepCloneable<TrackMoonTarget>, IBufferMessage
	{
		// Token: 0x0601B073 RID: 110707 RVA: 0x003EA0BC File Offset: 0x003E82BC
		[NullableContext(1)]
		public static TrackMoonTarget Create()
		{
			return new TrackMoonTarget();
		}

		// Token: 0x17005B16 RID: 23318
		// (get) Token: 0x0601B074 RID: 110708 RVA: 0x003EA0C3 File Offset: 0x003E82C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TrackMoonTarget> Parser
		{
			get
			{
				return TrackMoonTarget._parser;
			}
		}

		// Token: 0x17005B17 RID: 23319
		// (get) Token: 0x0601B075 RID: 110709 RVA: 0x003EA0CA File Offset: 0x003E82CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005B18 RID: 23320
		// (get) Token: 0x0601B076 RID: 110710 RVA: 0x003EA0CD File Offset: 0x003E82CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrackMoonTarget.Descriptor;
			}
		}

		// Token: 0x0601B077 RID: 110711 RVA: 0x003EA0D4 File Offset: 0x003E82D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonTarget()
		{
		}

		// Token: 0x0601B078 RID: 110712 RVA: 0x003EA0DC File Offset: 0x003E82DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonTarget(TrackMoonTarget other) : this()
		{
			this.id_ = other.id_;
			this.current_ = other.current_;
			this.target_ = other.target_;
			this.status_ = other.status_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B079 RID: 110713 RVA: 0x003EA130 File Offset: 0x003E8330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonTarget Clone()
		{
			return new TrackMoonTarget(this);
		}

		// Token: 0x17005B19 RID: 23321
		// (get) Token: 0x0601B07A RID: 110714 RVA: 0x003EA138 File Offset: 0x003E8338
		// (set) Token: 0x0601B07B RID: 110715 RVA: 0x003EA140 File Offset: 0x003E8340
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

		// Token: 0x17005B1A RID: 23322
		// (get) Token: 0x0601B07C RID: 110716 RVA: 0x003EA149 File Offset: 0x003E8349
		// (set) Token: 0x0601B07D RID: 110717 RVA: 0x003EA151 File Offset: 0x003E8351
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Current
		{
			get
			{
				return this.current_;
			}
			set
			{
				this.current_ = value;
			}
		}

		// Token: 0x17005B1B RID: 23323
		// (get) Token: 0x0601B07E RID: 110718 RVA: 0x003EA15A File Offset: 0x003E835A
		// (set) Token: 0x0601B07F RID: 110719 RVA: 0x003EA162 File Offset: 0x003E8362
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Target
		{
			get
			{
				return this.target_;
			}
			set
			{
				this.target_ = value;
			}
		}

		// Token: 0x17005B1C RID: 23324
		// (get) Token: 0x0601B080 RID: 110720 RVA: 0x003EA16B File Offset: 0x003E836B
		// (set) Token: 0x0601B081 RID: 110721 RVA: 0x003EA173 File Offset: 0x003E8373
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonTargetState Status
		{
			get
			{
				return this.status_;
			}
			set
			{
				this.status_ = value;
			}
		}

		// Token: 0x0601B082 RID: 110722 RVA: 0x003EA17C File Offset: 0x003E837C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrackMoonTarget);
		}

		// Token: 0x0601B083 RID: 110723 RVA: 0x003EA18C File Offset: 0x003E838C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrackMoonTarget other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Current == other.Current && this.Target == other.Target && this.Status == other.Status && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B084 RID: 110724 RVA: 0x003EA1F8 File Offset: 0x003E83F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Current != 0)
			{
				int num2 = num;
				int num3 = this.Current;
				num = (num2 ^ num3.GetHashCode());
			}
			if (this.Target != 0)
			{
				num ^= this.Target.GetHashCode();
			}
			if (this.Status != TrackMoonTargetState.TrackMoonTargetRunning)
			{
				num ^= this.Status.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B085 RID: 110725 RVA: 0x003EA288 File Offset: 0x003E8488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B086 RID: 110726 RVA: 0x003EA295 File Offset: 0x003E8495
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B087 RID: 110727 RVA: 0x003EA2A0 File Offset: 0x003E84A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.Current != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Current);
			}
			if (this.Target != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Target);
			}
			if (this.Status != TrackMoonTargetState.TrackMoonTargetRunning)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.Status);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B088 RID: 110728 RVA: 0x003EA330 File Offset: 0x003E8530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.Current != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Current);
			}
			if (this.Target != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Target);
			}
			if (this.Status != TrackMoonTargetState.TrackMoonTargetRunning)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Status);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B089 RID: 110729 RVA: 0x003EA3B8 File Offset: 0x003E85B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrackMoonTarget other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Current != 0)
			{
				this.Current = other.Current;
			}
			if (other.Target != 0)
			{
				this.Target = other.Target;
			}
			if (other.Status != TrackMoonTargetState.TrackMoonTargetRunning)
			{
				this.Status = other.Status;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B08A RID: 110730 RVA: 0x003EA430 File Offset: 0x003E8630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B08B RID: 110731 RVA: 0x003EA43C File Offset: 0x003E863C
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.Id = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.Current = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.Target = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.Status = (TrackMoonTargetState)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009C74 RID: 40052
		private static readonly MessageParser<TrackMoonTarget> _parser = new MessageParser<TrackMoonTarget>(() => new TrackMoonTarget());

		// Token: 0x04009C75 RID: 40053
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009C76 RID: 40054
		public const int IdFieldNumber = 1;

		// Token: 0x04009C77 RID: 40055
		private int id_;

		// Token: 0x04009C78 RID: 40056
		public const int CurrentFieldNumber = 2;

		// Token: 0x04009C79 RID: 40057
		private int current_;

		// Token: 0x04009C7A RID: 40058
		public const int TargetFieldNumber = 3;

		// Token: 0x04009C7B RID: 40059
		private int target_;

		// Token: 0x04009C7C RID: 40060
		public const int StatusFieldNumber = 4;

		// Token: 0x04009C7D RID: 40061
		private TrackMoonTargetState status_;
	}
}
