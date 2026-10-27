using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001F9 RID: 505
	[NetMessage(EMessageId.BuffDurationNotify)]
	public sealed class BuffDurationNotify : IMessage<BuffDurationNotify>, IMessage, IEquatable<BuffDurationNotify>, IDeepCloneable<BuffDurationNotify>, IBufferMessage
	{
		// Token: 0x06003825 RID: 14373 RVA: 0x0008C658 File Offset: 0x0008A858
		[NullableContext(1)]
		public static BuffDurationNotify Create()
		{
			return new BuffDurationNotify();
		}

		// Token: 0x1700091A RID: 2330
		// (get) Token: 0x06003826 RID: 14374 RVA: 0x0008C65F File Offset: 0x0008A85F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700091B RID: 2331
		// (get) Token: 0x06003827 RID: 14375 RVA: 0x0008C662 File Offset: 0x0008A862
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BuffDurationNotify.Descriptor;
			}
		}

		// Token: 0x06003828 RID: 14376 RVA: 0x0008C669 File Offset: 0x0008A869
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffDurationNotify()
		{
		}

		// Token: 0x06003829 RID: 14377 RVA: 0x0008C674 File Offset: 0x0008A874
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

		// Token: 0x0600382A RID: 14378 RVA: 0x0008C6C8 File Offset: 0x0008A8C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffDurationNotify Clone()
		{
			return new BuffDurationNotify(this);
		}

		// Token: 0x1700091C RID: 2332
		// (get) Token: 0x0600382B RID: 14379 RVA: 0x0008C6D0 File Offset: 0x0008A8D0
		// (set) Token: 0x0600382C RID: 14380 RVA: 0x0008C6D8 File Offset: 0x0008A8D8
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

		// Token: 0x1700091D RID: 2333
		// (get) Token: 0x0600382D RID: 14381 RVA: 0x0008C6E1 File Offset: 0x0008A8E1
		// (set) Token: 0x0600382E RID: 14382 RVA: 0x0008C6F9 File Offset: 0x0008A8F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float Duration
		{
			get
			{
				if ((this._hasBits0 & 1) != 0)
				{
					return this.duration_;
				}
				return BuffDurationNotify.DurationDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.duration_ = value;
			}
		}

		// Token: 0x1700091E RID: 2334
		// (get) Token: 0x0600382F RID: 14383 RVA: 0x0008C710 File Offset: 0x0008A910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasDuration
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06003830 RID: 14384 RVA: 0x0008C71D File Offset: 0x0008A91D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearDuration()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700091F RID: 2335
		// (get) Token: 0x06003831 RID: 14385 RVA: 0x0008C72E File Offset: 0x0008A92E
		// (set) Token: 0x06003832 RID: 14386 RVA: 0x0008C746 File Offset: 0x0008A946
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float LeftDuration
		{
			get
			{
				if ((this._hasBits0 & 2) != 0)
				{
					return this.leftDuration_;
				}
				return BuffDurationNotify.LeftDurationDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.leftDuration_ = value;
			}
		}

		// Token: 0x17000920 RID: 2336
		// (get) Token: 0x06003833 RID: 14387 RVA: 0x0008C75D File Offset: 0x0008A95D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasLeftDuration
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06003834 RID: 14388 RVA: 0x0008C76A File Offset: 0x0008A96A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearLeftDuration()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06003835 RID: 14389 RVA: 0x0008C77B File Offset: 0x0008A97B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BuffDurationNotify);
		}

		// Token: 0x06003836 RID: 14390 RVA: 0x0008C78C File Offset: 0x0008A98C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BuffDurationNotify other)
		{
			return other != null && (other == this || (this.HandleId == other.HandleId && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Duration, other.Duration) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.LeftDuration, other.LeftDuration) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003837 RID: 14391 RVA: 0x0008C7FC File Offset: 0x0008A9FC
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

		// Token: 0x06003838 RID: 14392 RVA: 0x0008C871 File Offset: 0x0008AA71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003839 RID: 14393 RVA: 0x0008C87E File Offset: 0x0008AA7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600383A RID: 14394 RVA: 0x0008C888 File Offset: 0x0008AA88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HasDuration)
			{
				output.WriteRawTag(21);
				output.WriteFloat(this.Duration);
			}
			if (this.HasLeftDuration)
			{
				output.WriteRawTag(45);
				output.WriteFloat(this.LeftDuration);
			}
			if (this.HandleId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.HandleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600383B RID: 14395 RVA: 0x0008C900 File Offset: 0x0008AB00
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

		// Token: 0x0600383C RID: 14396 RVA: 0x0008C958 File Offset: 0x0008AB58
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

		// Token: 0x0600383D RID: 14397 RVA: 0x0008C9BC File Offset: 0x0008ABBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600383E RID: 14398 RVA: 0x0008C9C8 File Offset: 0x0008ABC8
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
				if (num != 21U)
				{
					if (num != 45U)
					{
						if (num != 96U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
				else
				{
					this.Duration = input.ReadFloat();
				}
			}
		}

		// Token: 0x04002B1F RID: 11039
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002B20 RID: 11040
		private int _hasBits0;

		// Token: 0x04002B21 RID: 11041
		public const int HandleIdFieldNumber = 12;

		// Token: 0x04002B22 RID: 11042
		private int handleId_;

		// Token: 0x04002B23 RID: 11043
		public const int DurationFieldNumber = 2;

		// Token: 0x04002B24 RID: 11044
		private static readonly float DurationDefaultValue;

		// Token: 0x04002B25 RID: 11045
		private float duration_;

		// Token: 0x04002B26 RID: 11046
		public const int LeftDurationFieldNumber = 5;

		// Token: 0x04002B27 RID: 11047
		private static readonly float LeftDurationDefaultValue;

		// Token: 0x04002B28 RID: 11048
		private float leftDuration_;
	}
}
