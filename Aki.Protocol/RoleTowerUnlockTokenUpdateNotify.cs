using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010FF RID: 4351
	[NetMessage(EMessageId.RoleTowerUnlockTokenUpdateNotify)]
	public sealed class RoleTowerUnlockTokenUpdateNotify : IMessage<RoleTowerUnlockTokenUpdateNotify>, IMessage, IEquatable<RoleTowerUnlockTokenUpdateNotify>, IDeepCloneable<RoleTowerUnlockTokenUpdateNotify>, IBufferMessage
	{
		// Token: 0x0601742C RID: 95276 RVA: 0x00362AEC File Offset: 0x00360CEC
		[NullableContext(1)]
		public static RoleTowerUnlockTokenUpdateNotify Create()
		{
			return new RoleTowerUnlockTokenUpdateNotify();
		}

		// Token: 0x17004E27 RID: 20007
		// (get) Token: 0x0601742D RID: 95277 RVA: 0x00362AF3 File Offset: 0x00360CF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004E28 RID: 20008
		// (get) Token: 0x0601742E RID: 95278 RVA: 0x00362AF6 File Offset: 0x00360CF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTowerUnlockTokenUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0601742F RID: 95279 RVA: 0x00362AFD File Offset: 0x00360CFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerUnlockTokenUpdateNotify()
		{
		}

		// Token: 0x06017430 RID: 95280 RVA: 0x00362B10 File Offset: 0x00360D10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerUnlockTokenUpdateNotify(RoleTowerUnlockTokenUpdateNotify other) : this()
		{
			this.unlockTokens_ = other.unlockTokens_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017431 RID: 95281 RVA: 0x00362B3A File Offset: 0x00360D3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerUnlockTokenUpdateNotify Clone()
		{
			return new RoleTowerUnlockTokenUpdateNotify(this);
		}

		// Token: 0x17004E29 RID: 20009
		// (get) Token: 0x06017432 RID: 95282 RVA: 0x00362B42 File Offset: 0x00360D42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockTokens
		{
			get
			{
				return this.unlockTokens_;
			}
		}

		// Token: 0x06017433 RID: 95283 RVA: 0x00362B4A File Offset: 0x00360D4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTowerUnlockTokenUpdateNotify);
		}

		// Token: 0x06017434 RID: 95284 RVA: 0x00362B58 File Offset: 0x00360D58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTowerUnlockTokenUpdateNotify other)
		{
			return other != null && (other == this || (this.unlockTokens_.Equals(other.unlockTokens_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017435 RID: 95285 RVA: 0x00362B8C File Offset: 0x00360D8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.unlockTokens_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017436 RID: 95286 RVA: 0x00362BC0 File Offset: 0x00360DC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017437 RID: 95287 RVA: 0x00362BCD File Offset: 0x00360DCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017438 RID: 95288 RVA: 0x00362BD6 File Offset: 0x00360DD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.unlockTokens_.WriteTo(ref output, RoleTowerUnlockTokenUpdateNotify._repeated_unlockTokens_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017439 RID: 95289 RVA: 0x00362C00 File Offset: 0x00360E00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.unlockTokens_.CalculateSize(RoleTowerUnlockTokenUpdateNotify._repeated_unlockTokens_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601743A RID: 95290 RVA: 0x00362C39 File Offset: 0x00360E39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleTowerUnlockTokenUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.unlockTokens_.Add(other.unlockTokens_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601743B RID: 95291 RVA: 0x00362C67 File Offset: 0x00360E67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601743C RID: 95292 RVA: 0x00362C70 File Offset: 0x00360E70
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
				if (num != 24U && num != 26U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.unlockTokens_.AddEntriesFrom(ref input, RoleTowerUnlockTokenUpdateNotify._repeated_unlockTokens_codec);
				}
			}
		}

		// Token: 0x04008B18 RID: 35608
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008B19 RID: 35609
		public const int UnlockTokensFieldNumber = 3;

		// Token: 0x04008B1A RID: 35610
		private static readonly FieldCodec<int> _repeated_unlockTokens_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04008B1B RID: 35611
		private readonly RepeatedField<int> unlockTokens_ = new RepeatedField<int>();
	}
}
