using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000402 RID: 1026
	public sealed class DynamicAttachComponentPb : IMessage<DynamicAttachComponentPb>, IMessage, IEquatable<DynamicAttachComponentPb>, IDeepCloneable<DynamicAttachComponentPb>, IBufferMessage
	{
		// Token: 0x0600633C RID: 25404 RVA: 0x000EE9A5 File Offset: 0x000ECBA5
		[NullableContext(1)]
		public static DynamicAttachComponentPb Create()
		{
			return new DynamicAttachComponentPb();
		}

		// Token: 0x1700127A RID: 4730
		// (get) Token: 0x0600633D RID: 25405 RVA: 0x000EE9AC File Offset: 0x000ECBAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700127B RID: 4731
		// (get) Token: 0x0600633E RID: 25406 RVA: 0x000EE9AF File Offset: 0x000ECBAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DynamicAttachComponentPb.Descriptor;
			}
		}

		// Token: 0x0600633F RID: 25407 RVA: 0x000EE9B6 File Offset: 0x000ECBB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DynamicAttachComponentPb()
		{
		}

		// Token: 0x06006340 RID: 25408 RVA: 0x000EE9D4 File Offset: 0x000ECBD4
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

		// Token: 0x06006341 RID: 25409 RVA: 0x000EEA54 File Offset: 0x000ECC54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DynamicAttachComponentPb Clone()
		{
			return new DynamicAttachComponentPb(this);
		}

		// Token: 0x1700127C RID: 4732
		// (get) Token: 0x06006342 RID: 25410 RVA: 0x000EEA5C File Offset: 0x000ECC5C
		// (set) Token: 0x06006343 RID: 25411 RVA: 0x000EEA64 File Offset: 0x000ECC64
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

		// Token: 0x1700127D RID: 4733
		// (get) Token: 0x06006344 RID: 25412 RVA: 0x000EEA6D File Offset: 0x000ECC6D
		// (set) Token: 0x06006345 RID: 25413 RVA: 0x000EEA75 File Offset: 0x000ECC75
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

		// Token: 0x1700127E RID: 4734
		// (get) Token: 0x06006346 RID: 25414 RVA: 0x000EEA88 File Offset: 0x000ECC88
		// (set) Token: 0x06006347 RID: 25415 RVA: 0x000EEA90 File Offset: 0x000ECC90
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

		// Token: 0x1700127F RID: 4735
		// (get) Token: 0x06006348 RID: 25416 RVA: 0x000EEA99 File Offset: 0x000ECC99
		// (set) Token: 0x06006349 RID: 25417 RVA: 0x000EEAA1 File Offset: 0x000ECCA1
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

		// Token: 0x17001280 RID: 4736
		// (get) Token: 0x0600634A RID: 25418 RVA: 0x000EEAAA File Offset: 0x000ECCAA
		// (set) Token: 0x0600634B RID: 25419 RVA: 0x000EEAB2 File Offset: 0x000ECCB2
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

		// Token: 0x0600634C RID: 25420 RVA: 0x000EEAC5 File Offset: 0x000ECCC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DynamicAttachComponentPb);
		}

		// Token: 0x0600634D RID: 25421 RVA: 0x000EEAD4 File Offset: 0x000ECCD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DynamicAttachComponentPb other)
		{
			return other != null && (other == this || (this.AttachTarget == other.AttachTarget && !(this.AttachActor != other.AttachActor) && object.Equals(this.RelatePos, other.RelatePos) && object.Equals(this.RelateRot, other.RelateRot) && !(this.AttachPath != other.AttachPath) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600634E RID: 25422 RVA: 0x000EEB64 File Offset: 0x000ECD64
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

		// Token: 0x0600634F RID: 25423 RVA: 0x000EEC05 File Offset: 0x000ECE05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006350 RID: 25424 RVA: 0x000EEC12 File Offset: 0x000ECE12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006351 RID: 25425 RVA: 0x000EEC1C File Offset: 0x000ECE1C
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

		// Token: 0x06006352 RID: 25426 RVA: 0x000EECD4 File Offset: 0x000ECED4
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

		// Token: 0x06006353 RID: 25427 RVA: 0x000EED7C File Offset: 0x000ECF7C
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

		// Token: 0x06006354 RID: 25428 RVA: 0x000EEE42 File Offset: 0x000ED042
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006355 RID: 25429 RVA: 0x000EEE4C File Offset: 0x000ED04C
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

		// Token: 0x0400385D RID: 14429
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400385E RID: 14430
		public const int AttachTargetFieldNumber = 1;

		// Token: 0x0400385F RID: 14431
		private int attachTarget_;

		// Token: 0x04003860 RID: 14432
		public const int AttachActorFieldNumber = 2;

		// Token: 0x04003861 RID: 14433
		private string attachActor_ = "";

		// Token: 0x04003862 RID: 14434
		public const int RelatePosFieldNumber = 3;

		// Token: 0x04003863 RID: 14435
		private Vector relatePos_;

		// Token: 0x04003864 RID: 14436
		public const int RelateRotFieldNumber = 4;

		// Token: 0x04003865 RID: 14437
		private Rotator relateRot_;

		// Token: 0x04003866 RID: 14438
		public const int AttachPathFieldNumber = 5;

		// Token: 0x04003867 RID: 14439
		private string attachPath_ = "";
	}
}
