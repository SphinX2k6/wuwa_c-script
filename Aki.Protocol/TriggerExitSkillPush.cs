using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014DF RID: 5343
	[NetMessage(EMessageId.TriggerExitSkillPush)]
	public sealed class TriggerExitSkillPush : IMessage<TriggerExitSkillPush>, IMessage, IEquatable<TriggerExitSkillPush>, IDeepCloneable<TriggerExitSkillPush>, IBufferMessage
	{
		// Token: 0x0601C568 RID: 116072 RVA: 0x0041CB6A File Offset: 0x0041AD6A
		[NullableContext(1)]
		public static TriggerExitSkillPush Create()
		{
			return new TriggerExitSkillPush();
		}

		// Token: 0x17005FED RID: 24557
		// (get) Token: 0x0601C569 RID: 116073 RVA: 0x0041CB71 File Offset: 0x0041AD71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005FEE RID: 24558
		// (get) Token: 0x0601C56A RID: 116074 RVA: 0x0041CB74 File Offset: 0x0041AD74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TriggerExitSkillPush.Descriptor;
			}
		}

		// Token: 0x0601C56B RID: 116075 RVA: 0x0041CB7B File Offset: 0x0041AD7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TriggerExitSkillPush()
		{
		}

		// Token: 0x0601C56C RID: 116076 RVA: 0x0041CB83 File Offset: 0x0041AD83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TriggerExitSkillPush(TriggerExitSkillPush other) : this()
		{
			this.enterEntityId_ = other.enterEntityId_;
			this.leaveEntityId_ = other.leaveEntityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C56D RID: 116077 RVA: 0x0041CBB4 File Offset: 0x0041ADB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TriggerExitSkillPush Clone()
		{
			return new TriggerExitSkillPush(this);
		}

		// Token: 0x17005FEF RID: 24559
		// (get) Token: 0x0601C56E RID: 116078 RVA: 0x0041CBBC File Offset: 0x0041ADBC
		// (set) Token: 0x0601C56F RID: 116079 RVA: 0x0041CBC4 File Offset: 0x0041ADC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EnterEntityId
		{
			get
			{
				return this.enterEntityId_;
			}
			set
			{
				this.enterEntityId_ = value;
			}
		}

		// Token: 0x17005FF0 RID: 24560
		// (get) Token: 0x0601C570 RID: 116080 RVA: 0x0041CBCD File Offset: 0x0041ADCD
		// (set) Token: 0x0601C571 RID: 116081 RVA: 0x0041CBD5 File Offset: 0x0041ADD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long LeaveEntityId
		{
			get
			{
				return this.leaveEntityId_;
			}
			set
			{
				this.leaveEntityId_ = value;
			}
		}

		// Token: 0x0601C572 RID: 116082 RVA: 0x0041CBDE File Offset: 0x0041ADDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TriggerExitSkillPush);
		}

		// Token: 0x0601C573 RID: 116083 RVA: 0x0041CBEC File Offset: 0x0041ADEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TriggerExitSkillPush other)
		{
			return other != null && (other == this || (this.EnterEntityId == other.EnterEntityId && this.LeaveEntityId == other.LeaveEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C574 RID: 116084 RVA: 0x0041CC2C File Offset: 0x0041AE2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EnterEntityId != 0L)
			{
				num ^= this.EnterEntityId.GetHashCode();
			}
			if (this.LeaveEntityId != 0L)
			{
				num ^= this.LeaveEntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C575 RID: 116085 RVA: 0x0041CC84 File Offset: 0x0041AE84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C576 RID: 116086 RVA: 0x0041CC91 File Offset: 0x0041AE91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C577 RID: 116087 RVA: 0x0041CC9C File Offset: 0x0041AE9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EnterEntityId != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.EnterEntityId);
			}
			if (this.LeaveEntityId != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.LeaveEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C578 RID: 116088 RVA: 0x0041CCF8 File Offset: 0x0041AEF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EnterEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EnterEntityId);
			}
			if (this.LeaveEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.LeaveEntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C579 RID: 116089 RVA: 0x0041CD50 File Offset: 0x0041AF50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TriggerExitSkillPush other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EnterEntityId != 0L)
			{
				this.EnterEntityId = other.EnterEntityId;
			}
			if (other.LeaveEntityId != 0L)
			{
				this.LeaveEntityId = other.LeaveEntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C57A RID: 116090 RVA: 0x0041CDA0 File Offset: 0x0041AFA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C57B RID: 116091 RVA: 0x0041CDAC File Offset: 0x0041AFAC
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
				if (num != 40U)
				{
					if (num != 56U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.LeaveEntityId = input.ReadInt64();
					}
				}
				else
				{
					this.EnterEntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x0400A3C3 RID: 41923
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A3C4 RID: 41924
		public const int EnterEntityIdFieldNumber = 5;

		// Token: 0x0400A3C5 RID: 41925
		private long enterEntityId_;

		// Token: 0x0400A3C6 RID: 41926
		public const int LeaveEntityIdFieldNumber = 7;

		// Token: 0x0400A3C7 RID: 41927
		private long leaveEntityId_;
	}
}
