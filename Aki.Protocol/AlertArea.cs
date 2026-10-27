using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000DC RID: 220
	public sealed class AlertArea : IMessage<AlertArea>, IMessage, IEquatable<AlertArea>, IDeepCloneable<AlertArea>, IBufferMessage
	{
		// Token: 0x060020E9 RID: 8425 RVA: 0x00058717 File Offset: 0x00056917
		[NullableContext(1)]
		public static AlertArea Create()
		{
			return new AlertArea();
		}

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x060020EA RID: 8426 RVA: 0x0005871E File Offset: 0x0005691E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AlertArea> Parser
		{
			get
			{
				return AlertArea._parser;
			}
		}

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x060020EB RID: 8427 RVA: 0x00058725 File Offset: 0x00056925
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x060020EC RID: 8428 RVA: 0x00058728 File Offset: 0x00056928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AlertArea.Descriptor;
			}
		}

		// Token: 0x060020ED RID: 8429 RVA: 0x0005872F File Offset: 0x0005692F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AlertArea()
		{
		}

		// Token: 0x060020EE RID: 8430 RVA: 0x00058738 File Offset: 0x00056938
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

		// Token: 0x060020EF RID: 8431 RVA: 0x00058798 File Offset: 0x00056998
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AlertArea Clone()
		{
			return new AlertArea(this);
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x060020F0 RID: 8432 RVA: 0x000587A0 File Offset: 0x000569A0
		// (set) Token: 0x060020F1 RID: 8433 RVA: 0x000587A8 File Offset: 0x000569A8
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

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x060020F2 RID: 8434 RVA: 0x000587B1 File Offset: 0x000569B1
		// (set) Token: 0x060020F3 RID: 8435 RVA: 0x000587B9 File Offset: 0x000569B9
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

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x060020F4 RID: 8436 RVA: 0x000587C2 File Offset: 0x000569C2
		// (set) Token: 0x060020F5 RID: 8437 RVA: 0x000587CA File Offset: 0x000569CA
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

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x060020F6 RID: 8438 RVA: 0x000587D3 File Offset: 0x000569D3
		// (set) Token: 0x060020F7 RID: 8439 RVA: 0x000587DB File Offset: 0x000569DB
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

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x060020F8 RID: 8440 RVA: 0x000587E4 File Offset: 0x000569E4
		// (set) Token: 0x060020F9 RID: 8441 RVA: 0x000587EC File Offset: 0x000569EC
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

		// Token: 0x060020FA RID: 8442 RVA: 0x000587F5 File Offset: 0x000569F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AlertArea);
		}

		// Token: 0x060020FB RID: 8443 RVA: 0x00058804 File Offset: 0x00056A04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AlertArea other)
		{
			return other != null && (other == this || (this.AreaId == other.AreaId && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.AlertValue, other.AlertValue) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.ChangeSpeed, other.ChangeSpeed) && this.EnableUi == other.EnableUi && this.VisibleUi == other.VisibleUi && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060020FC RID: 8444 RVA: 0x00058894 File Offset: 0x00056A94
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

		// Token: 0x060020FD RID: 8445 RVA: 0x00058945 File Offset: 0x00056B45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060020FE RID: 8446 RVA: 0x00058952 File Offset: 0x00056B52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060020FF RID: 8447 RVA: 0x0005895C File Offset: 0x00056B5C
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

		// Token: 0x06002100 RID: 8448 RVA: 0x00058A14 File Offset: 0x00056C14
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

		// Token: 0x06002101 RID: 8449 RVA: 0x00058A8C File Offset: 0x00056C8C
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

		// Token: 0x06002102 RID: 8450 RVA: 0x00058B22 File Offset: 0x00056D22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002103 RID: 8451 RVA: 0x00058B2C File Offset: 0x00056D2C
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

		// Token: 0x04002415 RID: 9237
		private static readonly MessageParser<AlertArea> _parser = new MessageParser<AlertArea>(() => new AlertArea());

		// Token: 0x04002416 RID: 9238
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002417 RID: 9239
		public const int AreaIdFieldNumber = 1;

		// Token: 0x04002418 RID: 9240
		private int areaId_;

		// Token: 0x04002419 RID: 9241
		public const int AlertValueFieldNumber = 2;

		// Token: 0x0400241A RID: 9242
		private float alertValue_;

		// Token: 0x0400241B RID: 9243
		public const int ChangeSpeedFieldNumber = 3;

		// Token: 0x0400241C RID: 9244
		private float changeSpeed_;

		// Token: 0x0400241D RID: 9245
		public const int EnableUiFieldNumber = 4;

		// Token: 0x0400241E RID: 9246
		private bool enableUi_;

		// Token: 0x0400241F RID: 9247
		public const int VisibleUiFieldNumber = 5;

		// Token: 0x04002420 RID: 9248
		private bool visibleUi_;
	}
}
