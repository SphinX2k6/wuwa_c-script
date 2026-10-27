using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A73 RID: 2675
	[NetMessage(EMessageId.MotorIsEnablePush)]
	public sealed class MotorIsEnablePush : IMessage<MotorIsEnablePush>, IMessage, IEquatable<MotorIsEnablePush>, IDeepCloneable<MotorIsEnablePush>, IBufferMessage
	{
		// Token: 0x0600E939 RID: 59705 RVA: 0x00220F13 File Offset: 0x0021F113
		[NullableContext(1)]
		public static MotorIsEnablePush Create()
		{
			return new MotorIsEnablePush();
		}

		// Token: 0x17002F54 RID: 12116
		// (get) Token: 0x0600E93A RID: 59706 RVA: 0x00220F1A File Offset: 0x0021F11A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002F55 RID: 12117
		// (get) Token: 0x0600E93B RID: 59707 RVA: 0x00220F1D File Offset: 0x0021F11D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorIsEnablePush.Descriptor;
			}
		}

		// Token: 0x0600E93C RID: 59708 RVA: 0x00220F24 File Offset: 0x0021F124
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorIsEnablePush()
		{
		}

		// Token: 0x0600E93D RID: 59709 RVA: 0x00220F2C File Offset: 0x0021F12C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorIsEnablePush(MotorIsEnablePush other) : this()
		{
			this.id_ = other.id_;
			this.isEnable_ = other.isEnable_;
			this.combatCommon_ = ((other.combatCommon_ != null) ? other.combatCommon_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E93E RID: 59710 RVA: 0x00220F84 File Offset: 0x0021F184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorIsEnablePush Clone()
		{
			return new MotorIsEnablePush(this);
		}

		// Token: 0x17002F56 RID: 12118
		// (get) Token: 0x0600E93F RID: 59711 RVA: 0x00220F8C File Offset: 0x0021F18C
		// (set) Token: 0x0600E940 RID: 59712 RVA: 0x00220F94 File Offset: 0x0021F194
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Id
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

		// Token: 0x17002F57 RID: 12119
		// (get) Token: 0x0600E941 RID: 59713 RVA: 0x00220F9D File Offset: 0x0021F19D
		// (set) Token: 0x0600E942 RID: 59714 RVA: 0x00220FA5 File Offset: 0x0021F1A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsEnable
		{
			get
			{
				return this.isEnable_;
			}
			set
			{
				this.isEnable_ = value;
			}
		}

		// Token: 0x17002F58 RID: 12120
		// (get) Token: 0x0600E943 RID: 59715 RVA: 0x00220FAE File Offset: 0x0021F1AE
		// (set) Token: 0x0600E944 RID: 59716 RVA: 0x00220FB6 File Offset: 0x0021F1B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatCommon CombatCommon
		{
			get
			{
				return this.combatCommon_;
			}
			set
			{
				this.combatCommon_ = value;
			}
		}

		// Token: 0x0600E945 RID: 59717 RVA: 0x00220FBF File Offset: 0x0021F1BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorIsEnablePush);
		}

		// Token: 0x0600E946 RID: 59718 RVA: 0x00220FD0 File Offset: 0x0021F1D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorIsEnablePush other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.IsEnable == other.IsEnable && object.Equals(this.CombatCommon, other.CombatCommon) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E947 RID: 59719 RVA: 0x00221030 File Offset: 0x0021F230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0L)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.IsEnable)
			{
				num ^= this.IsEnable.GetHashCode();
			}
			if (this.combatCommon_ != null)
			{
				num ^= this.CombatCommon.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E948 RID: 59720 RVA: 0x0022109E File Offset: 0x0021F29E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E949 RID: 59721 RVA: 0x002210AB File Offset: 0x0021F2AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E94A RID: 59722 RVA: 0x002210B4 File Offset: 0x0021F2B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.combatCommon_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.CombatCommon);
			}
			if (this.Id != 0L)
			{
				output.WriteRawTag(112);
				output.WriteInt64(this.Id);
			}
			if (this.IsEnable)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.IsEnable);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E94B RID: 59723 RVA: 0x0022112C File Offset: 0x0021F32C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Id);
			}
			if (this.IsEnable)
			{
				num += 2;
			}
			if (this.combatCommon_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CombatCommon);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E94C RID: 59724 RVA: 0x00221190 File Offset: 0x0021F390
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorIsEnablePush other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0L)
			{
				this.Id = other.Id;
			}
			if (other.IsEnable)
			{
				this.IsEnable = other.IsEnable;
			}
			if (other.combatCommon_ != null)
			{
				if (this.combatCommon_ == null)
				{
					this.CombatCommon = new CombatCommon();
				}
				this.CombatCommon.MergeFrom(other.CombatCommon);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E94D RID: 59725 RVA: 0x0022120C File Offset: 0x0021F40C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E94E RID: 59726 RVA: 0x00221218 File Offset: 0x0021F418
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
				if (num != 66U)
				{
					if (num != 112U)
					{
						if (num != 120U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.IsEnable = input.ReadBool();
						}
					}
					else
					{
						this.Id = input.ReadInt64();
					}
				}
				else
				{
					if (this.combatCommon_ == null)
					{
						this.CombatCommon = new CombatCommon();
					}
					input.ReadMessage(this.CombatCommon);
				}
			}
		}

		// Token: 0x04005EDE RID: 24286
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005EDF RID: 24287
		public const int IdFieldNumber = 14;

		// Token: 0x04005EE0 RID: 24288
		private long id_;

		// Token: 0x04005EE1 RID: 24289
		public const int IsEnableFieldNumber = 15;

		// Token: 0x04005EE2 RID: 24290
		private bool isEnable_;

		// Token: 0x04005EE3 RID: 24291
		public const int CombatCommonFieldNumber = 8;

		// Token: 0x04005EE4 RID: 24292
		private CombatCommon combatCommon_;
	}
}
