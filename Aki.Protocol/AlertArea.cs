using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000DD RID: 221
	public sealed class AlertArea : IMessage<AlertArea>, IMessage, IEquatable<AlertArea>, IDeepCloneable<AlertArea>, IBufferMessage
	{
		// Token: 0x06002132 RID: 8498 RVA: 0x000593CB File Offset: 0x000575CB
		[NullableContext(1)]
		public static AlertArea Create()
		{
			return new AlertArea();
		}

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x06002133 RID: 8499 RVA: 0x000593D2 File Offset: 0x000575D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AlertArea> Parser
		{
			get
			{
				return AlertArea._parser;
			}
		}

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x06002134 RID: 8500 RVA: 0x000593D9 File Offset: 0x000575D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x06002135 RID: 8501 RVA: 0x000593DC File Offset: 0x000575DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AlertArea.Descriptor;
			}
		}

		// Token: 0x06002136 RID: 8502 RVA: 0x000593E3 File Offset: 0x000575E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AlertArea()
		{
		}

		// Token: 0x06002137 RID: 8503 RVA: 0x000593EC File Offset: 0x000575EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AlertArea(AlertArea other) : this()
		{
			this.areaId_ = other.areaId_;
			this.alertValue_ = other.alertValue_;
			this.changeSpeed_ = other.changeSpeed_;
			this.enableUi_ = other.enableUi_;
			this.visibleUi_ = other.visibleUi_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002138 RID: 8504 RVA: 0x0005944C File Offset: 0x0005764C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AlertArea Clone()
		{
			return new AlertArea(this);
		}

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x06002139 RID: 8505 RVA: 0x00059454 File Offset: 0x00057654
		// (set) Token: 0x0600213A RID: 8506 RVA: 0x0005945C File Offset: 0x0005765C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AreaId
		{
			get
			{
				return this.areaId_;
			}
			set
			{
				this.areaId_ = value;
			}
		}

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x0600213B RID: 8507 RVA: 0x00059465 File Offset: 0x00057665
		// (set) Token: 0x0600213C RID: 8508 RVA: 0x0005946D File Offset: 0x0005766D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float AlertValue
		{
			get
			{
				return this.alertValue_;
			}
			set
			{
				this.alertValue_ = value;
			}
		}

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x0600213D RID: 8509 RVA: 0x00059476 File Offset: 0x00057676
		// (set) Token: 0x0600213E RID: 8510 RVA: 0x0005947E File Offset: 0x0005767E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float ChangeSpeed
		{
			get
			{
				return this.changeSpeed_;
			}
			set
			{
				this.changeSpeed_ = value;
			}
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x0600213F RID: 8511 RVA: 0x00059487 File Offset: 0x00057687
		// (set) Token: 0x06002140 RID: 8512 RVA: 0x0005948F File Offset: 0x0005768F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool EnableUi
		{
			get
			{
				return this.enableUi_;
			}
			set
			{
				this.enableUi_ = value;
			}
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x06002141 RID: 8513 RVA: 0x00059498 File Offset: 0x00057698
		// (set) Token: 0x06002142 RID: 8514 RVA: 0x000594A0 File Offset: 0x000576A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool VisibleUi
		{
			get
			{
				return this.visibleUi_;
			}
			set
			{
				this.visibleUi_ = value;
			}
		}

		// Token: 0x06002143 RID: 8515 RVA: 0x000594A9 File Offset: 0x000576A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AlertArea);
		}

		// Token: 0x06002144 RID: 8516 RVA: 0x000594B8 File Offset: 0x000576B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AlertArea other)
		{
			return other != null && (other == this || (this.AreaId == other.AreaId && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.AlertValue, other.AlertValue) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.ChangeSpeed, other.ChangeSpeed) && this.EnableUi == other.EnableUi && this.VisibleUi == other.VisibleUi && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002145 RID: 8517 RVA: 0x00059548 File Offset: 0x00057748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AreaId != 0)
			{
				num ^= this.AreaId.GetHashCode();
			}
			if (this.AlertValue != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.AlertValue);
			}
			if (this.ChangeSpeed != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.ChangeSpeed);
			}
			if (this.EnableUi)
			{
				num ^= this.EnableUi.GetHashCode();
			}
			if (this.VisibleUi)
			{
				num ^= this.VisibleUi.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002146 RID: 8518 RVA: 0x000595F9 File Offset: 0x000577F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002147 RID: 8519 RVA: 0x00059606 File Offset: 0x00057806
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002148 RID: 8520 RVA: 0x00059610 File Offset: 0x00057810
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AreaId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.AreaId);
			}
			if (this.AlertValue != 0f)
			{
				output.WriteRawTag(21);
				output.WriteFloat(this.AlertValue);
			}
			if (this.ChangeSpeed != 0f)
			{
				output.WriteRawTag(29);
				output.WriteFloat(this.ChangeSpeed);
			}
			if (this.EnableUi)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.EnableUi);
			}
			if (this.VisibleUi)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.VisibleUi);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002149 RID: 8521 RVA: 0x000596C8 File Offset: 0x000578C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AreaId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AreaId);
			}
			if (this.AlertValue != 0f)
			{
				num += 5;
			}
			if (this.ChangeSpeed != 0f)
			{
				num += 5;
			}
			if (this.EnableUi)
			{
				num += 2;
			}
			if (this.VisibleUi)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600214A RID: 8522 RVA: 0x00059740 File Offset: 0x00057940
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AlertArea other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AreaId != 0)
			{
				this.AreaId = other.AreaId;
			}
			if (other.AlertValue != 0f)
			{
				this.AlertValue = other.AlertValue;
			}
			if (other.ChangeSpeed != 0f)
			{
				this.ChangeSpeed = other.ChangeSpeed;
			}
			if (other.EnableUi)
			{
				this.EnableUi = other.EnableUi;
			}
			if (other.VisibleUi)
			{
				this.VisibleUi = other.VisibleUi;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600214B RID: 8523 RVA: 0x000597D6 File Offset: 0x000579D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600214C RID: 8524 RVA: 0x000597E0 File Offset: 0x000579E0
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
				if (num <= 21U)
				{
					if (num == 8U)
					{
						this.AreaId = input.ReadInt32();
						continue;
					}
					if (num == 21U)
					{
						this.AlertValue = input.ReadFloat();
						continue;
					}
				}
				else
				{
					if (num == 29U)
					{
						this.ChangeSpeed = input.ReadFloat();
						continue;
					}
					if (num == 32U)
					{
						this.EnableUi = input.ReadBool();
						continue;
					}
					if (num == 40U)
					{
						this.VisibleUi = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002478 RID: 9336
		private static readonly MessageParser<AlertArea> _parser = new MessageParser<AlertArea>(() => new AlertArea());

		// Token: 0x04002479 RID: 9337
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400247A RID: 9338
		public const int AreaIdFieldNumber = 1;

		// Token: 0x0400247B RID: 9339
		private int areaId_;

		// Token: 0x0400247C RID: 9340
		public const int AlertValueFieldNumber = 2;

		// Token: 0x0400247D RID: 9341
		private float alertValue_;

		// Token: 0x0400247E RID: 9342
		public const int ChangeSpeedFieldNumber = 3;

		// Token: 0x0400247F RID: 9343
		private float changeSpeed_;

		// Token: 0x04002480 RID: 9344
		public const int EnableUiFieldNumber = 4;

		// Token: 0x04002481 RID: 9345
		private bool enableUi_;

		// Token: 0x04002482 RID: 9346
		public const int VisibleUiFieldNumber = 5;

		// Token: 0x04002483 RID: 9347
		private bool visibleUi_;
	}
}
