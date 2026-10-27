using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A25 RID: 2597
	[NetMessage(EMessageId.MotorCycleCruiseStatePush)]
	public sealed class MotorCycleCruiseStatePush : IMessage<MotorCycleCruiseStatePush>, IMessage, IEquatable<MotorCycleCruiseStatePush>, IDeepCloneable<MotorCycleCruiseStatePush>, IBufferMessage
	{
		// Token: 0x0600E308 RID: 58120 RVA: 0x00213CE1 File Offset: 0x00211EE1
		[NullableContext(1)]
		public static MotorCycleCruiseStatePush Create()
		{
			return new MotorCycleCruiseStatePush();
		}

		// Token: 0x17002E0B RID: 11787
		// (get) Token: 0x0600E309 RID: 58121 RVA: 0x00213CE8 File Offset: 0x00211EE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002E0C RID: 11788
		// (get) Token: 0x0600E30A RID: 58122 RVA: 0x00213CEB File Offset: 0x00211EEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorCycleCruiseStatePush.Descriptor;
			}
		}

		// Token: 0x0600E30B RID: 58123 RVA: 0x00213CF2 File Offset: 0x00211EF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorCycleCruiseStatePush()
		{
		}

		// Token: 0x0600E30C RID: 58124 RVA: 0x00213CFA File Offset: 0x00211EFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorCycleCruiseStatePush(MotorCycleCruiseStatePush other) : this()
		{
			this.isStart_ = other.isStart_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E30D RID: 58125 RVA: 0x00213D1F File Offset: 0x00211F1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorCycleCruiseStatePush Clone()
		{
			return new MotorCycleCruiseStatePush(this);
		}

		// Token: 0x17002E0D RID: 11789
		// (get) Token: 0x0600E30E RID: 58126 RVA: 0x00213D27 File Offset: 0x00211F27
		// (set) Token: 0x0600E30F RID: 58127 RVA: 0x00213D2F File Offset: 0x00211F2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsStart
		{
			get
			{
				return this.isStart_;
			}
			set
			{
				this.isStart_ = value;
			}
		}

		// Token: 0x0600E310 RID: 58128 RVA: 0x00213D38 File Offset: 0x00211F38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorCycleCruiseStatePush);
		}

		// Token: 0x0600E311 RID: 58129 RVA: 0x00213D46 File Offset: 0x00211F46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorCycleCruiseStatePush other)
		{
			return other != null && (other == this || (this.IsStart == other.IsStart && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E312 RID: 58130 RVA: 0x00213D74 File Offset: 0x00211F74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsStart)
			{
				num ^= this.IsStart.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E313 RID: 58131 RVA: 0x00213DB3 File Offset: 0x00211FB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E314 RID: 58132 RVA: 0x00213DC0 File Offset: 0x00211FC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E315 RID: 58133 RVA: 0x00213DC9 File Offset: 0x00211FC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsStart)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.IsStart);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E316 RID: 58134 RVA: 0x00213DFC File Offset: 0x00211FFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsStart)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E317 RID: 58135 RVA: 0x00213E2E File Offset: 0x0021202E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorCycleCruiseStatePush other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsStart)
			{
				this.IsStart = other.IsStart;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E318 RID: 58136 RVA: 0x00213E5F File Offset: 0x0021205F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E319 RID: 58137 RVA: 0x00213E68 File Offset: 0x00212068
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.IsStart = input.ReadBool();
				}
			}
		}

		// Token: 0x04005D1F RID: 23839
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005D20 RID: 23840
		public const int IsStartFieldNumber = 11;

		// Token: 0x04005D21 RID: 23841
		private bool isStart_;
	}
}
