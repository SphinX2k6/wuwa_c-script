using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001FE RID: 510
	[NetMessage(EMessageId.BuffDurationNotify)]
	public sealed class BuffDurationNotify : IMessage<BuffDurationNotify>, IMessage, IEquatable<BuffDurationNotify>, IDeepCloneable<BuffDurationNotify>, IBufferMessage
	{
		// Token: 0x060038CA RID: 14538 RVA: 0x0008E268 File Offset: 0x0008C468
		[NullableContext(1)]
		public static BuffDurationNotify Create()
		{
			return new BuffDurationNotify();
		}

		// Token: 0x17000939 RID: 2361
		// (get) Token: 0x060038CB RID: 14539 RVA: 0x0008E26F File Offset: 0x0008C46F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700093A RID: 2362
		// (get) Token: 0x060038CC RID: 14540 RVA: 0x0008E272 File Offset: 0x0008C472
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BuffDurationNotify.Descriptor;
			}
		}

		// Token: 0x060038CD RID: 14541 RVA: 0x0008E279 File Offset: 0x0008C479
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffDurationNotify()
		{
		}

		// Token: 0x060038CE RID: 14542 RVA: 0x0008E284 File Offset: 0x0008C484
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffDurationNotify(BuffDurationNotify other) : this()
		{
			this._hasBits0 = other._hasBits0;
			this.handleId_ = other.handleId_;
			this.duration_ = other.duration_;
			this.leftDuration_ = other.leftDuration_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060038CF RID: 14543 RVA: 0x0008E2D8 File Offset: 0x0008C4D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffDurationNotify Clone()
		{
			return new BuffDurationNotify(this);
		}

		// Token: 0x1700093B RID: 2363
		// (get) Token: 0x060038D0 RID: 14544 RVA: 0x0008E2E0 File Offset: 0x0008C4E0
		// (set) Token: 0x060038D1 RID: 14545 RVA: 0x0008E2E8 File Offset: 0x0008C4E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HandleId
		{
			get
			{
				return this.handleId_;
			}
			set
			{
				this.handleId_ = value;
			}
		}

		// Token: 0x1700093C RID: 2364
		// (get) Token: 0x060038D2 RID: 14546 RVA: 0x0008E2F1 File Offset: 0x0008C4F1
		// (set) Token: 0x060038D3 RID: 14547 RVA: 0x0008E309 File Offset: 0x0008C509
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float Duration
		{
			get
			{
				if ((this._hasBits0 & 2) != 0)
				{
					return this.duration_;
				}
				return BuffDurationNotify.DurationDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.duration_ = value;
			}
		}

		// Token: 0x1700093D RID: 2365
		// (get) Token: 0x060038D4 RID: 14548 RVA: 0x0008E320 File Offset: 0x0008C520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasDuration
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060038D5 RID: 14549 RVA: 0x0008E32D File Offset: 0x0008C52D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearDuration()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x1700093E RID: 2366
		// (get) Token: 0x060038D6 RID: 14550 RVA: 0x0008E33E File Offset: 0x0008C53E
		// (set) Token: 0x060038D7 RID: 14551 RVA: 0x0008E356 File Offset: 0x0008C556
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float LeftDuration
		{
			get
			{
				if ((this._hasBits0 & 1) != 0)
				{
					return this.leftDuration_;
				}
				return BuffDurationNotify.LeftDurationDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.leftDuration_ = value;
			}
		}

		// Token: 0x1700093F RID: 2367
		// (get) Token: 0x060038D8 RID: 14552 RVA: 0x0008E36D File Offset: 0x0008C56D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasLeftDuration
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060038D9 RID: 14553 RVA: 0x0008E37A File Offset: 0x0008C57A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearLeftDuration()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x060038DA RID: 14554 RVA: 0x0008E38B File Offset: 0x0008C58B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BuffDurationNotify);
		}

		// Token: 0x060038DB RID: 14555 RVA: 0x0008E39C File Offset: 0x0008C59C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BuffDurationNotify other)
		{
			return other != null && (other == this || (this.HandleId == other.HandleId && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Duration, other.Duration) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.LeftDuration, other.LeftDuration) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060038DC RID: 14556 RVA: 0x0008E40C File Offset: 0x0008C60C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HandleId != 0)
			{
				num ^= this.HandleId.GetHashCode();
			}
			if (this.HasDuration)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.Duration);
			}
			if (this.HasLeftDuration)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.LeftDuration);
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060038DD RID: 14557 RVA: 0x0008E481 File Offset: 0x0008C681
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060038DE RID: 14558 RVA: 0x0008E48E File Offset: 0x0008C68E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060038DF RID: 14559 RVA: 0x0008E498 File Offset: 0x0008C698
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HasLeftDuration)
			{
				output.WriteRawTag(53);
				output.WriteFloat(this.LeftDuration);
			}
			if (this.HandleId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.HandleId);
			}
			if (this.HasDuration)
			{
				output.WriteRawTag(109);
				output.WriteFloat(this.Duration);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060038E0 RID: 14560 RVA: 0x0008E510 File Offset: 0x0008C710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HandleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HandleId);
			}
			if (this.HasDuration)
			{
				num += 5;
			}
			if (this.HasLeftDuration)
			{
				num += 5;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060038E1 RID: 14561 RVA: 0x0008E568 File Offset: 0x0008C768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BuffDurationNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HandleId != 0)
			{
				this.HandleId = other.HandleId;
			}
			if (other.HasDuration)
			{
				this.Duration = other.Duration;
			}
			if (other.HasLeftDuration)
			{
				this.LeftDuration = other.LeftDuration;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060038E2 RID: 14562 RVA: 0x0008E5CC File Offset: 0x0008C7CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060038E3 RID: 14563 RVA: 0x0008E5D8 File Offset: 0x0008C7D8
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
				if (num != 53U)
				{
					if (num != 64U)
					{
						if (num != 109U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Duration = input.ReadFloat();
						}
					}
					else
					{
						this.HandleId = input.ReadInt32();
					}
				}
				else
				{
					this.LeftDuration = input.ReadFloat();
				}
			}
		}

		// Token: 0x04002BA1 RID: 11169
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002BA2 RID: 11170
		private int _hasBits0;

		// Token: 0x04002BA3 RID: 11171
		public const int HandleIdFieldNumber = 8;

		// Token: 0x04002BA4 RID: 11172
		private int handleId_;

		// Token: 0x04002BA5 RID: 11173
		public const int DurationFieldNumber = 13;

		// Token: 0x04002BA6 RID: 11174
		private static readonly float DurationDefaultValue;

		// Token: 0x04002BA7 RID: 11175
		private float duration_;

		// Token: 0x04002BA8 RID: 11176
		public const int LeftDurationFieldNumber = 6;

		// Token: 0x04002BA9 RID: 11177
		private static readonly float LeftDurationDefaultValue;

		// Token: 0x04002BAA RID: 11178
		private float leftDuration_;
	}
}
