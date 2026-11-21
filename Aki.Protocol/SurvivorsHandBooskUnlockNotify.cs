using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001339 RID: 4921
	[NetMessage(EMessageId.SurvivorsHandBooskUnlockNotify)]
	public sealed class SurvivorsHandBooskUnlockNotify : IMessage<SurvivorsHandBooskUnlockNotify>, IMessage, IEquatable<SurvivorsHandBooskUnlockNotify>, IDeepCloneable<SurvivorsHandBooskUnlockNotify>, IBufferMessage
	{
		// Token: 0x0601A3B3 RID: 107443 RVA: 0x003D2DFE File Offset: 0x003D0FFE
		[NullableContext(1)]
		public static SurvivorsHandBooskUnlockNotify Create()
		{
			return new SurvivorsHandBooskUnlockNotify();
		}

		// Token: 0x170058D6 RID: 22742
		// (get) Token: 0x0601A3B4 RID: 107444 RVA: 0x003D2E05 File Offset: 0x003D1005
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170058D7 RID: 22743
		// (get) Token: 0x0601A3B5 RID: 107445 RVA: 0x003D2E08 File Offset: 0x003D1008
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsHandBooskUnlockNotify.Descriptor;
			}
		}

		// Token: 0x0601A3B6 RID: 107446 RVA: 0x003D2E0F File Offset: 0x003D100F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsHandBooskUnlockNotify()
		{
		}

		// Token: 0x0601A3B7 RID: 107447 RVA: 0x003D2E38 File Offset: 0x003D1038
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsHandBooskUnlockNotify(SurvivorsHandBooskUnlockNotify other) : this()
		{
			this.activityId_ = other.activityId_;
			this.unlockWeaponHandBooks_ = other.unlockWeaponHandBooks_.Clone();
			this.unlockRoleHandBooks_ = other.unlockRoleHandBooks_.Clone();
			this.unlockItemHandBooks_ = other.unlockItemHandBooks_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A3B8 RID: 107448 RVA: 0x003D2E9B File Offset: 0x003D109B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsHandBooskUnlockNotify Clone()
		{
			return new SurvivorsHandBooskUnlockNotify(this);
		}

		// Token: 0x170058D8 RID: 22744
		// (get) Token: 0x0601A3B9 RID: 107449 RVA: 0x003D2EA3 File Offset: 0x003D10A3
		// (set) Token: 0x0601A3BA RID: 107450 RVA: 0x003D2EAB File Offset: 0x003D10AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x170058D9 RID: 22745
		// (get) Token: 0x0601A3BB RID: 107451 RVA: 0x003D2EB4 File Offset: 0x003D10B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockWeaponHandBooks
		{
			get
			{
				return this.unlockWeaponHandBooks_;
			}
		}

		// Token: 0x170058DA RID: 22746
		// (get) Token: 0x0601A3BC RID: 107452 RVA: 0x003D2EBC File Offset: 0x003D10BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockRoleHandBooks
		{
			get
			{
				return this.unlockRoleHandBooks_;
			}
		}

		// Token: 0x170058DB RID: 22747
		// (get) Token: 0x0601A3BD RID: 107453 RVA: 0x003D2EC4 File Offset: 0x003D10C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockItemHandBooks
		{
			get
			{
				return this.unlockItemHandBooks_;
			}
		}

		// Token: 0x0601A3BE RID: 107454 RVA: 0x003D2ECC File Offset: 0x003D10CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsHandBooskUnlockNotify);
		}

		// Token: 0x0601A3BF RID: 107455 RVA: 0x003D2EDC File Offset: 0x003D10DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsHandBooskUnlockNotify other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.unlockWeaponHandBooks_.Equals(other.unlockWeaponHandBooks_) && this.unlockRoleHandBooks_.Equals(other.unlockRoleHandBooks_) && this.unlockItemHandBooks_.Equals(other.unlockItemHandBooks_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A3C0 RID: 107456 RVA: 0x003D2F54 File Offset: 0x003D1154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			num ^= this.unlockWeaponHandBooks_.GetHashCode();
			num ^= this.unlockRoleHandBooks_.GetHashCode();
			num ^= this.unlockItemHandBooks_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A3C1 RID: 107457 RVA: 0x003D2FBD File Offset: 0x003D11BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A3C2 RID: 107458 RVA: 0x003D2FCA File Offset: 0x003D11CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A3C3 RID: 107459 RVA: 0x003D2FD4 File Offset: 0x003D11D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.unlockWeaponHandBooks_.WriteTo(ref output, SurvivorsHandBooskUnlockNotify._repeated_unlockWeaponHandBooks_codec);
			this.unlockItemHandBooks_.WriteTo(ref output, SurvivorsHandBooskUnlockNotify._repeated_unlockItemHandBooks_codec);
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.ActivityId);
			}
			this.unlockRoleHandBooks_.WriteTo(ref output, SurvivorsHandBooskUnlockNotify._repeated_unlockRoleHandBooks_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A3C4 RID: 107460 RVA: 0x003D3044 File Offset: 0x003D1244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			num += this.unlockWeaponHandBooks_.CalculateSize(SurvivorsHandBooskUnlockNotify._repeated_unlockWeaponHandBooks_codec);
			num += this.unlockRoleHandBooks_.CalculateSize(SurvivorsHandBooskUnlockNotify._repeated_unlockRoleHandBooks_codec);
			num += this.unlockItemHandBooks_.CalculateSize(SurvivorsHandBooskUnlockNotify._repeated_unlockItemHandBooks_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A3C5 RID: 107461 RVA: 0x003D30BC File Offset: 0x003D12BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SurvivorsHandBooskUnlockNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this.unlockWeaponHandBooks_.Add(other.unlockWeaponHandBooks_);
			this.unlockRoleHandBooks_.Add(other.unlockRoleHandBooks_);
			this.unlockItemHandBooks_.Add(other.unlockItemHandBooks_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A3C6 RID: 107462 RVA: 0x003D312B File Offset: 0x003D132B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A3C7 RID: 107463 RVA: 0x003D3134 File Offset: 0x003D1334
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
				if (num <= 40U)
				{
					if (num == 32U || num == 34U)
					{
						this.unlockWeaponHandBooks_.AddEntriesFrom(ref input, SurvivorsHandBooskUnlockNotify._repeated_unlockWeaponHandBooks_codec);
						continue;
					}
					if (num == 40U)
					{
						goto IL_64;
					}
				}
				else if (num <= 48U)
				{
					if (num == 42U)
					{
						goto IL_64;
					}
					if (num == 48U)
					{
						this.ActivityId = input.ReadInt32();
						continue;
					}
				}
				else if (num == 64U || num == 66U)
				{
					this.unlockRoleHandBooks_.AddEntriesFrom(ref input, SurvivorsHandBooskUnlockNotify._repeated_unlockRoleHandBooks_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_64:
				this.unlockItemHandBooks_.AddEntriesFrom(ref input, SurvivorsHandBooskUnlockNotify._repeated_unlockItemHandBooks_codec);
			}
		}

		// Token: 0x04009A42 RID: 39490
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009A43 RID: 39491
		public const int ActivityIdFieldNumber = 6;

		// Token: 0x04009A44 RID: 39492
		private int activityId_;

		// Token: 0x04009A45 RID: 39493
		public const int UnlockWeaponHandBooksFieldNumber = 4;

		// Token: 0x04009A46 RID: 39494
		private static readonly FieldCodec<int> _repeated_unlockWeaponHandBooks_codec = FieldCodec.ForInt32(34U);

		// Token: 0x04009A47 RID: 39495
		private readonly RepeatedField<int> unlockWeaponHandBooks_ = new RepeatedField<int>();

		// Token: 0x04009A48 RID: 39496
		public const int UnlockRoleHandBooksFieldNumber = 8;

		// Token: 0x04009A49 RID: 39497
		private static readonly FieldCodec<int> _repeated_unlockRoleHandBooks_codec = FieldCodec.ForInt32(66U);

		// Token: 0x04009A4A RID: 39498
		private readonly RepeatedField<int> unlockRoleHandBooks_ = new RepeatedField<int>();

		// Token: 0x04009A4B RID: 39499
		public const int UnlockItemHandBooksFieldNumber = 5;

		// Token: 0x04009A4C RID: 39500
		private static readonly FieldCodec<int> _repeated_unlockItemHandBooks_codec = FieldCodec.ForInt32(42U);

		// Token: 0x04009A4D RID: 39501
		private readonly RepeatedField<int> unlockItemHandBooks_ = new RepeatedField<int>();
	}
}
