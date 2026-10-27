using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000419 RID: 1049
	public sealed class DynamicAttachComponentPb : IMessage<DynamicAttachComponentPb>, IMessage, IEquatable<DynamicAttachComponentPb>, IDeepCloneable<DynamicAttachComponentPb>, IBufferMessage
	{
		// Token: 0x060064CC RID: 25804 RVA: 0x000F1B19 File Offset: 0x000EFD19
		[NullableContext(1)]
		public static DynamicAttachComponentPb Create()
		{
			return new DynamicAttachComponentPb();
		}

		// Token: 0x170012CF RID: 4815
		// (get) Token: 0x060064CD RID: 25805 RVA: 0x000F1B20 File Offset: 0x000EFD20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170012D0 RID: 4816
		// (get) Token: 0x060064CE RID: 25806 RVA: 0x000F1B23 File Offset: 0x000EFD23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DynamicAttachComponentPb.Descriptor;
			}
		}

		// Token: 0x060064CF RID: 25807 RVA: 0x000F1B2A File Offset: 0x000EFD2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DynamicAttachComponentPb()
		{
		}

		// Token: 0x060064D0 RID: 25808 RVA: 0x000F1B48 File Offset: 0x000EFD48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DynamicAttachComponentPb(DynamicAttachComponentPb other) : this()
		{
			this.attachTarget_ = other.attachTarget_;
			this.attachActor_ = other.attachActor_;
			this.relatePos_ = ((other.relatePos_ != null) ? other.relatePos_.Clone() : null);
			this.relateRot_ = ((other.relateRot_ != null) ? other.relateRot_.Clone() : null);
			this.attachPath_ = other.attachPath_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060064D1 RID: 25809 RVA: 0x000F1BC8 File Offset: 0x000EFDC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DynamicAttachComponentPb Clone()
		{
			return new DynamicAttachComponentPb(this);
		}

		// Token: 0x170012D1 RID: 4817
		// (get) Token: 0x060064D2 RID: 25810 RVA: 0x000F1BD0 File Offset: 0x000EFDD0
		// (set) Token: 0x060064D3 RID: 25811 RVA: 0x000F1BD8 File Offset: 0x000EFDD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AttachTarget
		{
			get
			{
				return this.attachTarget_;
			}
			set
			{
				this.attachTarget_ = value;
			}
		}

		// Token: 0x170012D2 RID: 4818
		// (get) Token: 0x060064D4 RID: 25812 RVA: 0x000F1BE1 File Offset: 0x000EFDE1
		// (set) Token: 0x060064D5 RID: 25813 RVA: 0x000F1BE9 File Offset: 0x000EFDE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string AttachActor
		{
			get
			{
				return this.attachActor_;
			}
			set
			{
				this.attachActor_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170012D3 RID: 4819
		// (get) Token: 0x060064D6 RID: 25814 RVA: 0x000F1BFC File Offset: 0x000EFDFC
		// (set) Token: 0x060064D7 RID: 25815 RVA: 0x000F1C04 File Offset: 0x000EFE04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector RelatePos
		{
			get
			{
				return this.relatePos_;
			}
			set
			{
				this.relatePos_ = value;
			}
		}

		// Token: 0x170012D4 RID: 4820
		// (get) Token: 0x060064D8 RID: 25816 RVA: 0x000F1C0D File Offset: 0x000EFE0D
		// (set) Token: 0x060064D9 RID: 25817 RVA: 0x000F1C15 File Offset: 0x000EFE15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Rotator RelateRot
		{
			get
			{
				return this.relateRot_;
			}
			set
			{
				this.relateRot_ = value;
			}
		}

		// Token: 0x170012D5 RID: 4821
		// (get) Token: 0x060064DA RID: 25818 RVA: 0x000F1C1E File Offset: 0x000EFE1E
		// (set) Token: 0x060064DB RID: 25819 RVA: 0x000F1C26 File Offset: 0x000EFE26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string AttachPath
		{
			get
			{
				return this.attachPath_;
			}
			set
			{
				this.attachPath_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x060064DC RID: 25820 RVA: 0x000F1C39 File Offset: 0x000EFE39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DynamicAttachComponentPb);
		}

		// Token: 0x060064DD RID: 25821 RVA: 0x000F1C48 File Offset: 0x000EFE48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DynamicAttachComponentPb other)
		{
			return other != null && (other == this || (this.AttachTarget == other.AttachTarget && !(this.AttachActor != other.AttachActor) && object.Equals(this.RelatePos, other.RelatePos) && object.Equals(this.RelateRot, other.RelateRot) && !(this.AttachPath != other.AttachPath) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060064DE RID: 25822 RVA: 0x000F1CD8 File Offset: 0x000EFED8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AttachTarget != 0)
			{
				num ^= this.AttachTarget.GetHashCode();
			}
			if (this.AttachActor.Length != 0)
			{
				num ^= this.AttachActor.GetHashCode();
			}
			if (this.relatePos_ != null)
			{
				num ^= this.RelatePos.GetHashCode();
			}
			if (this.relateRot_ != null)
			{
				num ^= this.RelateRot.GetHashCode();
			}
			if (this.AttachPath.Length != 0)
			{
				num ^= this.AttachPath.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060064DF RID: 25823 RVA: 0x000F1D79 File Offset: 0x000EFF79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060064E0 RID: 25824 RVA: 0x000F1D86 File Offset: 0x000EFF86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060064E1 RID: 25825 RVA: 0x000F1D90 File Offset: 0x000EFF90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AttachTarget != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.AttachTarget);
			}
			if (this.AttachActor.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteString(this.AttachActor);
			}
			if (this.relatePos_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.RelatePos);
			}
			if (this.relateRot_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.RelateRot);
			}
			if (this.AttachPath.Length != 0)
			{
				output.WriteRawTag(42);
				output.WriteString(this.AttachPath);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060064E2 RID: 25826 RVA: 0x000F1E48 File Offset: 0x000F0048
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AttachTarget != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AttachTarget);
			}
			if (this.AttachActor.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.AttachActor);
			}
			if (this.relatePos_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RelatePos);
			}
			if (this.relateRot_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RelateRot);
			}
			if (this.AttachPath.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.AttachPath);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060064E3 RID: 25827 RVA: 0x000F1EF0 File Offset: 0x000F00F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DynamicAttachComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AttachTarget != 0)
			{
				this.AttachTarget = other.AttachTarget;
			}
			if (other.AttachActor.Length != 0)
			{
				this.AttachActor = other.AttachActor;
			}
			if (other.relatePos_ != null)
			{
				if (this.relatePos_ == null)
				{
					this.RelatePos = new Vector();
				}
				this.RelatePos.MergeFrom(other.RelatePos);
			}
			if (other.relateRot_ != null)
			{
				if (this.relateRot_ == null)
				{
					this.RelateRot = new Rotator();
				}
				this.RelateRot.MergeFrom(other.RelateRot);
			}
			if (other.AttachPath.Length != 0)
			{
				this.AttachPath = other.AttachPath;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060064E4 RID: 25828 RVA: 0x000F1FB6 File Offset: 0x000F01B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060064E5 RID: 25829 RVA: 0x000F1FC0 File Offset: 0x000F01C0
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
				if (num <= 18U)
				{
					if (num == 8U)
					{
						this.AttachTarget = input.ReadInt32();
						continue;
					}
					if (num == 18U)
					{
						this.AttachActor = input.ReadString();
						continue;
					}
				}
				else
				{
					if (num == 26U)
					{
						if (this.relatePos_ == null)
						{
							this.RelatePos = new Vector();
						}
						input.ReadMessage(this.RelatePos);
						continue;
					}
					if (num == 34U)
					{
						if (this.relateRot_ == null)
						{
							this.RelateRot = new Rotator();
						}
						input.ReadMessage(this.RelateRot);
						continue;
					}
					if (num == 42U)
					{
						this.AttachPath = input.ReadString();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003870 RID: 14448
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003871 RID: 14449
		public const int AttachTargetFieldNumber = 1;

		// Token: 0x04003872 RID: 14450
		private int attachTarget_;

		// Token: 0x04003873 RID: 14451
		public const int AttachActorFieldNumber = 2;

		// Token: 0x04003874 RID: 14452
		private string attachActor_ = "";

		// Token: 0x04003875 RID: 14453
		public const int RelatePosFieldNumber = 3;

		// Token: 0x04003876 RID: 14454
		private Vector relatePos_;

		// Token: 0x04003877 RID: 14455
		public const int RelateRotFieldNumber = 4;

		// Token: 0x04003878 RID: 14456
		private Rotator relateRot_;

		// Token: 0x04003879 RID: 14457
		public const int AttachPathFieldNumber = 5;

		// Token: 0x0400387A RID: 14458
		private string attachPath_ = "";
	}
}
