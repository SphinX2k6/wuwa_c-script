using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200140B RID: 5131
	[NetMessage(EMessageId.TrapDefenseBdGroupUnlockNotify)]
	public sealed class TrapDefenseBdGroupUnlockNotify : IMessage<TrapDefenseBdGroupUnlockNotify>, IMessage, IEquatable<TrapDefenseBdGroupUnlockNotify>, IDeepCloneable<TrapDefenseBdGroupUnlockNotify>, IBufferMessage
	{
		// Token: 0x0601B32F RID: 111407 RVA: 0x003F11E9 File Offset: 0x003EF3E9
		[NullableContext(1)]
		public static TrapDefenseBdGroupUnlockNotify Create()
		{
			return new TrapDefenseBdGroupUnlockNotify();
		}

		// Token: 0x17005BBD RID: 23485
		// (get) Token: 0x0601B330 RID: 111408 RVA: 0x003F11F0 File Offset: 0x003EF3F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005BBE RID: 23486
		// (get) Token: 0x0601B331 RID: 111409 RVA: 0x003F11F3 File Offset: 0x003EF3F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseBdGroupUnlockNotify.Descriptor;
			}
		}

		// Token: 0x0601B332 RID: 111410 RVA: 0x003F11FA File Offset: 0x003EF3FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseBdGroupUnlockNotify()
		{
		}

		// Token: 0x0601B333 RID: 111411 RVA: 0x003F120D File Offset: 0x003EF40D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseBdGroupUnlockNotify(TrapDefenseBdGroupUnlockNotify other) : this()
		{
			this.unlockBdGroups_ = other.unlockBdGroups_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B334 RID: 111412 RVA: 0x003F1237 File Offset: 0x003EF437
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseBdGroupUnlockNotify Clone()
		{
			return new TrapDefenseBdGroupUnlockNotify(this);
		}

		// Token: 0x17005BBF RID: 23487
		// (get) Token: 0x0601B335 RID: 111413 RVA: 0x003F123F File Offset: 0x003EF43F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockBdGroups
		{
			get
			{
				return this.unlockBdGroups_;
			}
		}

		// Token: 0x0601B336 RID: 111414 RVA: 0x003F1247 File Offset: 0x003EF447
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseBdGroupUnlockNotify);
		}

		// Token: 0x0601B337 RID: 111415 RVA: 0x003F1255 File Offset: 0x003EF455
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseBdGroupUnlockNotify other)
		{
			return other != null && (other == this || (this.unlockBdGroups_.Equals(other.unlockBdGroups_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B338 RID: 111416 RVA: 0x003F1288 File Offset: 0x003EF488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.unlockBdGroups_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B339 RID: 111417 RVA: 0x003F12BC File Offset: 0x003EF4BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B33A RID: 111418 RVA: 0x003F12C9 File Offset: 0x003EF4C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B33B RID: 111419 RVA: 0x003F12D2 File Offset: 0x003EF4D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.unlockBdGroups_.WriteTo(ref output, TrapDefenseBdGroupUnlockNotify._repeated_unlockBdGroups_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B33C RID: 111420 RVA: 0x003F12FC File Offset: 0x003EF4FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.unlockBdGroups_.CalculateSize(TrapDefenseBdGroupUnlockNotify._repeated_unlockBdGroups_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B33D RID: 111421 RVA: 0x003F1335 File Offset: 0x003EF535
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseBdGroupUnlockNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.unlockBdGroups_.Add(other.unlockBdGroups_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B33E RID: 111422 RVA: 0x003F1363 File Offset: 0x003EF563
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B33F RID: 111423 RVA: 0x003F136C File Offset: 0x003EF56C
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
				if (num != 72U && num != 74U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.unlockBdGroups_.AddEntriesFrom(ref input, TrapDefenseBdGroupUnlockNotify._repeated_unlockBdGroups_codec);
				}
			}
		}

		// Token: 0x04009D5C RID: 40284
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009D5D RID: 40285
		public const int UnlockBdGroupsFieldNumber = 9;

		// Token: 0x04009D5E RID: 40286
		private static readonly FieldCodec<int> _repeated_unlockBdGroups_codec = FieldCodec.ForInt32(74U);

		// Token: 0x04009D5F RID: 40287
		private readonly RepeatedField<int> unlockBdGroups_ = new RepeatedField<int>();
	}
}
