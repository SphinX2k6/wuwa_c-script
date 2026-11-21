using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A8B RID: 2699
	[NetMessage(EMessageId.MotorPositionStatePush)]
	public sealed class MotorPositionStatePush : IMessage<MotorPositionStatePush>, IMessage, IEquatable<MotorPositionStatePush>, IDeepCloneable<MotorPositionStatePush>, IBufferMessage
	{
		// Token: 0x0600EB63 RID: 60259 RVA: 0x002264A4 File Offset: 0x002246A4
		[NullableContext(1)]
		public static MotorPositionStatePush Create()
		{
			return new MotorPositionStatePush();
		}

		// Token: 0x17002FCA RID: 12234
		// (get) Token: 0x0600EB64 RID: 60260 RVA: 0x002264AB File Offset: 0x002246AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002FCB RID: 12235
		// (get) Token: 0x0600EB65 RID: 60261 RVA: 0x002264AE File Offset: 0x002246AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorPositionStatePush.Descriptor;
			}
		}

		// Token: 0x0600EB66 RID: 60262 RVA: 0x002264B5 File Offset: 0x002246B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorPositionStatePush()
		{
		}

		// Token: 0x0600EB67 RID: 60263 RVA: 0x002264BD File Offset: 0x002246BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorPositionStatePush(MotorPositionStatePush other) : this()
		{
			this.positionState_ = other.positionState_;
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EB68 RID: 60264 RVA: 0x002264EE File Offset: 0x002246EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorPositionStatePush Clone()
		{
			return new MotorPositionStatePush(this);
		}

		// Token: 0x17002FCC RID: 12236
		// (get) Token: 0x0600EB69 RID: 60265 RVA: 0x002264F6 File Offset: 0x002246F6
		// (set) Token: 0x0600EB6A RID: 60266 RVA: 0x002264FE File Offset: 0x002246FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PositionState
		{
			get
			{
				return this.positionState_;
			}
			set
			{
				this.positionState_ = value;
			}
		}

		// Token: 0x17002FCD RID: 12237
		// (get) Token: 0x0600EB6B RID: 60267 RVA: 0x00226507 File Offset: 0x00224707
		// (set) Token: 0x0600EB6C RID: 60268 RVA: 0x0022650F File Offset: 0x0022470F
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

		// Token: 0x0600EB6D RID: 60269 RVA: 0x00226518 File Offset: 0x00224718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorPositionStatePush);
		}

		// Token: 0x0600EB6E RID: 60270 RVA: 0x00226526 File Offset: 0x00224726
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorPositionStatePush other)
		{
			return other != null && (other == this || (this.PositionState == other.PositionState && this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EB6F RID: 60271 RVA: 0x00226564 File Offset: 0x00224764
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PositionState != 0)
			{
				num ^= this.PositionState.GetHashCode();
			}
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600EB70 RID: 60272 RVA: 0x002265BC File Offset: 0x002247BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EB71 RID: 60273 RVA: 0x002265C9 File Offset: 0x002247C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EB72 RID: 60274 RVA: 0x002265D4 File Offset: 0x002247D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PositionState != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.PositionState);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600EB73 RID: 60275 RVA: 0x00226630 File Offset: 0x00224830
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PositionState != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PositionState);
			}
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600EB74 RID: 60276 RVA: 0x00226688 File Offset: 0x00224888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorPositionStatePush other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PositionState != 0)
			{
				this.PositionState = other.PositionState;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600EB75 RID: 60277 RVA: 0x002266D8 File Offset: 0x002248D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EB76 RID: 60278 RVA: 0x002266E4 File Offset: 0x002248E4
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
				if (num != 56U)
				{
					if (num != 64U)
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
					this.PositionState = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005FED RID: 24557
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005FEE RID: 24558
		public const int PositionStateFieldNumber = 7;

		// Token: 0x04005FEF RID: 24559
		private int positionState_;

		// Token: 0x04005FF0 RID: 24560
		public const int EntityIdFieldNumber = 8;

		// Token: 0x04005FF1 RID: 24561
		private long entityId_;
	}
}
