using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006EF RID: 1775
	public sealed class GolemCrackLevelInfo : IMessage<GolemCrackLevelInfo>, IMessage, IEquatable<GolemCrackLevelInfo>, IDeepCloneable<GolemCrackLevelInfo>, IBufferMessage
	{
		// Token: 0x0600A206 RID: 41478 RVA: 0x00187F99 File Offset: 0x00186199
		[NullableContext(1)]
		public static GolemCrackLevelInfo Create()
		{
			return new GolemCrackLevelInfo();
		}

		// Token: 0x1700208A RID: 8330
		// (get) Token: 0x0600A207 RID: 41479 RVA: 0x00187FA0 File Offset: 0x001861A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GolemCrackLevelInfo> Parser
		{
			get
			{
				return GolemCrackLevelInfo._parser;
			}
		}

		// Token: 0x1700208B RID: 8331
		// (get) Token: 0x0600A208 RID: 41480 RVA: 0x00187FA7 File Offset: 0x001861A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700208C RID: 8332
		// (get) Token: 0x0600A209 RID: 41481 RVA: 0x00187FAA File Offset: 0x001861AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GolemCrackLevelInfo.Descriptor;
			}
		}

		// Token: 0x0600A20A RID: 41482 RVA: 0x00187FB1 File Offset: 0x001861B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GolemCrackLevelInfo()
		{
		}

		// Token: 0x0600A20B RID: 41483 RVA: 0x00187FBC File Offset: 0x001861BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GolemCrackLevelInfo(GolemCrackLevelInfo other) : this()
		{
			this._hasBits0 = other._hasBits0;
			this.id_ = other.id_;
			this.state_ = other.state_;
			this.unlockTime_ = other.unlockTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A20C RID: 41484 RVA: 0x00188010 File Offset: 0x00186210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GolemCrackLevelInfo Clone()
		{
			return new GolemCrackLevelInfo(this);
		}

		// Token: 0x1700208D RID: 8333
		// (get) Token: 0x0600A20D RID: 41485 RVA: 0x00188018 File Offset: 0x00186218
		// (set) Token: 0x0600A20E RID: 41486 RVA: 0x00188020 File Offset: 0x00186220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
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

		// Token: 0x1700208E RID: 8334
		// (get) Token: 0x0600A20F RID: 41487 RVA: 0x00188029 File Offset: 0x00186229
		// (set) Token: 0x0600A210 RID: 41488 RVA: 0x00188041 File Offset: 0x00186241
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GolemCrackState State
		{
			get
			{
				if ((this._hasBits0 & 1) != 0)
				{
					return this.state_;
				}
				return GolemCrackLevelInfo.StateDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.state_ = value;
			}
		}

		// Token: 0x1700208F RID: 8335
		// (get) Token: 0x0600A211 RID: 41489 RVA: 0x00188058 File Offset: 0x00186258
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasState
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600A212 RID: 41490 RVA: 0x00188065 File Offset: 0x00186265
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearState()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002090 RID: 8336
		// (get) Token: 0x0600A213 RID: 41491 RVA: 0x00188076 File Offset: 0x00186276
		// (set) Token: 0x0600A214 RID: 41492 RVA: 0x0018808E File Offset: 0x0018628E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long UnlockTime
		{
			get
			{
				if ((this._hasBits0 & 2) != 0)
				{
					return this.unlockTime_;
				}
				return GolemCrackLevelInfo.UnlockTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.unlockTime_ = value;
			}
		}

		// Token: 0x17002091 RID: 8337
		// (get) Token: 0x0600A215 RID: 41493 RVA: 0x001880A5 File Offset: 0x001862A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasUnlockTime
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600A216 RID: 41494 RVA: 0x001880B2 File Offset: 0x001862B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearUnlockTime()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x0600A217 RID: 41495 RVA: 0x001880C3 File Offset: 0x001862C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GolemCrackLevelInfo);
		}

		// Token: 0x0600A218 RID: 41496 RVA: 0x001880D4 File Offset: 0x001862D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GolemCrackLevelInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.State == other.State && this.UnlockTime == other.UnlockTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A219 RID: 41497 RVA: 0x00188130 File Offset: 0x00186330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.HasState)
			{
				num ^= this.State.GetHashCode();
			}
			if (this.HasUnlockTime)
			{
				num ^= this.UnlockTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A21A RID: 41498 RVA: 0x001881A7 File Offset: 0x001863A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A21B RID: 41499 RVA: 0x001881B4 File Offset: 0x001863B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A21C RID: 41500 RVA: 0x001881C0 File Offset: 0x001863C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.HasState)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.State);
			}
			if (this.HasUnlockTime)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.UnlockTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A21D RID: 41501 RVA: 0x00188234 File Offset: 0x00186434
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.HasState)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.State);
			}
			if (this.HasUnlockTime)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.UnlockTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A21E RID: 41502 RVA: 0x001882A4 File Offset: 0x001864A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GolemCrackLevelInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.HasState)
			{
				this.State = other.State;
			}
			if (other.HasUnlockTime)
			{
				this.UnlockTime = other.UnlockTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A21F RID: 41503 RVA: 0x00188308 File Offset: 0x00186508
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A220 RID: 41504 RVA: 0x00188314 File Offset: 0x00186514
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
				if (num != 8U)
				{
					if (num != 16U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.UnlockTime = input.ReadInt64();
						}
					}
					else
					{
						this.State = (GolemCrackState)input.ReadEnum();
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004B79 RID: 19321
		private static readonly MessageParser<GolemCrackLevelInfo> _parser = new MessageParser<GolemCrackLevelInfo>(() => new GolemCrackLevelInfo());

		// Token: 0x04004B7A RID: 19322
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004B7B RID: 19323
		private int _hasBits0;

		// Token: 0x04004B7C RID: 19324
		public const int IdFieldNumber = 1;

		// Token: 0x04004B7D RID: 19325
		private int id_;

		// Token: 0x04004B7E RID: 19326
		public const int StateFieldNumber = 2;

		// Token: 0x04004B7F RID: 19327
		private static readonly GolemCrackState StateDefaultValue = GolemCrackState.GolemCrackLocked;

		// Token: 0x04004B80 RID: 19328
		private GolemCrackState state_;

		// Token: 0x04004B81 RID: 19329
		public const int UnlockTimeFieldNumber = 3;

		// Token: 0x04004B82 RID: 19330
		private static readonly long UnlockTimeDefaultValue = 0L;

		// Token: 0x04004B83 RID: 19331
		private long unlockTime_;
	}
}
