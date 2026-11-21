using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A72 RID: 2674
	[NetMessage(EMessageId.MotorOutlookEditPresetRequest)]
	public sealed class MotorOutlookEditPresetRequest : IMessage<MotorOutlookEditPresetRequest>, IMessage, IEquatable<MotorOutlookEditPresetRequest>, IDeepCloneable<MotorOutlookEditPresetRequest>, IBufferMessage
	{
		// Token: 0x0600E95F RID: 59743 RVA: 0x002218BE File Offset: 0x0021FABE
		[NullableContext(1)]
		public static MotorOutlookEditPresetRequest Create()
		{
			return new MotorOutlookEditPresetRequest();
		}

		// Token: 0x17002F58 RID: 12120
		// (get) Token: 0x0600E960 RID: 59744 RVA: 0x002218C5 File Offset: 0x0021FAC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002F59 RID: 12121
		// (get) Token: 0x0600E961 RID: 59745 RVA: 0x002218C8 File Offset: 0x0021FAC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorOutlookEditPresetRequest.Descriptor;
			}
		}

		// Token: 0x0600E962 RID: 59746 RVA: 0x002218CF File Offset: 0x0021FACF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookEditPresetRequest()
		{
		}

		// Token: 0x0600E963 RID: 59747 RVA: 0x002218D7 File Offset: 0x0021FAD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookEditPresetRequest(MotorOutlookEditPresetRequest other) : this()
		{
			this.presetPlan_ = ((other.presetPlan_ != null) ? other.presetPlan_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E964 RID: 59748 RVA: 0x0022190C File Offset: 0x0021FB0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookEditPresetRequest Clone()
		{
			return new MotorOutlookEditPresetRequest(this);
		}

		// Token: 0x17002F5A RID: 12122
		// (get) Token: 0x0600E965 RID: 59749 RVA: 0x00221914 File Offset: 0x0021FB14
		// (set) Token: 0x0600E966 RID: 59750 RVA: 0x0022191C File Offset: 0x0021FB1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookPresetPlanPb PresetPlan
		{
			get
			{
				return this.presetPlan_;
			}
			set
			{
				this.presetPlan_ = value;
			}
		}

		// Token: 0x0600E967 RID: 59751 RVA: 0x00221925 File Offset: 0x0021FB25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorOutlookEditPresetRequest);
		}

		// Token: 0x0600E968 RID: 59752 RVA: 0x00221933 File Offset: 0x0021FB33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorOutlookEditPresetRequest other)
		{
			return other != null && (other == this || (object.Equals(this.PresetPlan, other.PresetPlan) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E969 RID: 59753 RVA: 0x00221968 File Offset: 0x0021FB68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.presetPlan_ != null)
			{
				num ^= this.PresetPlan.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E96A RID: 59754 RVA: 0x002219A4 File Offset: 0x0021FBA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E96B RID: 59755 RVA: 0x002219B1 File Offset: 0x0021FBB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E96C RID: 59756 RVA: 0x002219BA File Offset: 0x0021FBBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.presetPlan_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.PresetPlan);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E96D RID: 59757 RVA: 0x002219EC File Offset: 0x0021FBEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.presetPlan_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PresetPlan);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E96E RID: 59758 RVA: 0x00221A2C File Offset: 0x0021FC2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorOutlookEditPresetRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.presetPlan_ != null)
			{
				if (this.presetPlan_ == null)
				{
					this.PresetPlan = new MotorOutlookPresetPlanPb();
				}
				this.PresetPlan.MergeFrom(other.PresetPlan);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E96F RID: 59759 RVA: 0x00221A80 File Offset: 0x0021FC80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E970 RID: 59760 RVA: 0x00221A8C File Offset: 0x0021FC8C
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
				if (num != 114U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.presetPlan_ == null)
					{
						this.PresetPlan = new MotorOutlookPresetPlanPb();
					}
					input.ReadMessage(this.PresetPlan);
				}
			}
		}

		// Token: 0x04005F42 RID: 24386
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005F43 RID: 24387
		public const int PresetPlanFieldNumber = 14;

		// Token: 0x04005F44 RID: 24388
		private MotorOutlookPresetPlanPb presetPlan_;
	}
}
