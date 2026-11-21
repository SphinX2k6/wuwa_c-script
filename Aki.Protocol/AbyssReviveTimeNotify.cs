using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200003E RID: 62
	[NetMessage(EMessageId.AbyssReviveTimeNotify)]
	public sealed class AbyssReviveTimeNotify : IMessage<AbyssReviveTimeNotify>, IMessage, IEquatable<AbyssReviveTimeNotify>, IDeepCloneable<AbyssReviveTimeNotify>, IBufferMessage
	{
		// Token: 0x06001393 RID: 5011 RVA: 0x000350D6 File Offset: 0x000332D6
		[NullableContext(1)]
		public static AbyssReviveTimeNotify Create()
		{
			return new AbyssReviveTimeNotify();
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06001394 RID: 5012 RVA: 0x000350DD File Offset: 0x000332DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06001395 RID: 5013 RVA: 0x000350E0 File Offset: 0x000332E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssReviveTimeNotify.Descriptor;
			}
		}

		// Token: 0x06001396 RID: 5014 RVA: 0x000350E7 File Offset: 0x000332E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssReviveTimeNotify()
		{
		}

		// Token: 0x06001397 RID: 5015 RVA: 0x000350FA File Offset: 0x000332FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssReviveTimeNotify(AbyssReviveTimeNotify other) : this()
		{
			this.reviveTimeList_ = other.reviveTimeList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001398 RID: 5016 RVA: 0x00035124 File Offset: 0x00033324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssReviveTimeNotify Clone()
		{
			return new AbyssReviveTimeNotify(this);
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06001399 RID: 5017 RVA: 0x0003512C File Offset: 0x0003332C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AbyssEntityReviveTime> ReviveTimeList
		{
			get
			{
				return this.reviveTimeList_;
			}
		}

		// Token: 0x0600139A RID: 5018 RVA: 0x00035134 File Offset: 0x00033334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssReviveTimeNotify);
		}

		// Token: 0x0600139B RID: 5019 RVA: 0x00035142 File Offset: 0x00033342
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssReviveTimeNotify other)
		{
			return other != null && (other == this || (this.reviveTimeList_.Equals(other.reviveTimeList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600139C RID: 5020 RVA: 0x00035178 File Offset: 0x00033378
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.reviveTimeList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600139D RID: 5021 RVA: 0x000351AC File Offset: 0x000333AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600139E RID: 5022 RVA: 0x000351B9 File Offset: 0x000333B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600139F RID: 5023 RVA: 0x000351C2 File Offset: 0x000333C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.reviveTimeList_.WriteTo(ref output, AbyssReviveTimeNotify._repeated_reviveTimeList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060013A0 RID: 5024 RVA: 0x000351EC File Offset: 0x000333EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.reviveTimeList_.CalculateSize(AbyssReviveTimeNotify._repeated_reviveTimeList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060013A1 RID: 5025 RVA: 0x00035225 File Offset: 0x00033425
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AbyssReviveTimeNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.reviveTimeList_.Add(other.reviveTimeList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060013A2 RID: 5026 RVA: 0x00035253 File Offset: 0x00033453
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060013A3 RID: 5027 RVA: 0x0003525C File Offset: 0x0003345C
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
				if (num != 82U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.reviveTimeList_.AddEntriesFrom(ref input, AbyssReviveTimeNotify._repeated_reviveTimeList_codec);
				}
			}
		}

		// Token: 0x04002064 RID: 8292
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002065 RID: 8293
		public const int ReviveTimeListFieldNumber = 10;

		// Token: 0x04002066 RID: 8294
		private static readonly FieldCodec<AbyssEntityReviveTime> _repeated_reviveTimeList_codec = FieldCodec.ForMessage<AbyssEntityReviveTime>(82U, AbyssEntityReviveTime.Parser);

		// Token: 0x04002067 RID: 8295
		private readonly RepeatedField<AbyssEntityReviveTime> reviveTimeList_ = new RepeatedField<AbyssEntityReviveTime>();
	}
}
