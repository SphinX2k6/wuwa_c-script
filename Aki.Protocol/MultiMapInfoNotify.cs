using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AEA RID: 2794
	[NetMessage(EMessageId.MultiMapInfoNotify)]
	public sealed class MultiMapInfoNotify : IMessage<MultiMapInfoNotify>, IMessage, IEquatable<MultiMapInfoNotify>, IDeepCloneable<MultiMapInfoNotify>, IBufferMessage
	{
		// Token: 0x0600F2F5 RID: 62197 RVA: 0x00237668 File Offset: 0x00235868
		[NullableContext(1)]
		public static MultiMapInfoNotify Create()
		{
			return new MultiMapInfoNotify();
		}

		// Token: 0x17003176 RID: 12662
		// (get) Token: 0x0600F2F6 RID: 62198 RVA: 0x0023766F File Offset: 0x0023586F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003177 RID: 12663
		// (get) Token: 0x0600F2F7 RID: 62199 RVA: 0x00237672 File Offset: 0x00235872
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MultiMapInfoNotify.Descriptor;
			}
		}

		// Token: 0x0600F2F8 RID: 62200 RVA: 0x00237679 File Offset: 0x00235879
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MultiMapInfoNotify()
		{
		}

		// Token: 0x0600F2F9 RID: 62201 RVA: 0x00237697 File Offset: 0x00235897
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MultiMapInfoNotify(MultiMapInfoNotify other) : this()
		{
			this.unlockMultiMapId_ = other.unlockMultiMapId_.Clone();
			this.unlockBlockId_ = other.unlockBlockId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F2FA RID: 62202 RVA: 0x002376D2 File Offset: 0x002358D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MultiMapInfoNotify Clone()
		{
			return new MultiMapInfoNotify(this);
		}

		// Token: 0x17003178 RID: 12664
		// (get) Token: 0x0600F2FB RID: 62203 RVA: 0x002376DA File Offset: 0x002358DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockMultiMapId
		{
			get
			{
				return this.unlockMultiMapId_;
			}
		}

		// Token: 0x17003179 RID: 12665
		// (get) Token: 0x0600F2FC RID: 62204 RVA: 0x002376E2 File Offset: 0x002358E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockBlockId
		{
			get
			{
				return this.unlockBlockId_;
			}
		}

		// Token: 0x0600F2FD RID: 62205 RVA: 0x002376EA File Offset: 0x002358EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MultiMapInfoNotify);
		}

		// Token: 0x0600F2FE RID: 62206 RVA: 0x002376F8 File Offset: 0x002358F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MultiMapInfoNotify other)
		{
			return other != null && (other == this || (this.unlockMultiMapId_.Equals(other.unlockMultiMapId_) && this.unlockBlockId_.Equals(other.unlockBlockId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F2FF RID: 62207 RVA: 0x0023774C File Offset: 0x0023594C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.unlockMultiMapId_.GetHashCode();
			num ^= this.unlockBlockId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F300 RID: 62208 RVA: 0x0023778E File Offset: 0x0023598E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F301 RID: 62209 RVA: 0x0023779B File Offset: 0x0023599B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F302 RID: 62210 RVA: 0x002377A4 File Offset: 0x002359A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.unlockMultiMapId_.WriteTo(ref output, MultiMapInfoNotify._repeated_unlockMultiMapId_codec);
			this.unlockBlockId_.WriteTo(ref output, MultiMapInfoNotify._repeated_unlockBlockId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F303 RID: 62211 RVA: 0x002377DC File Offset: 0x002359DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.unlockMultiMapId_.CalculateSize(MultiMapInfoNotify._repeated_unlockMultiMapId_codec);
			num += this.unlockBlockId_.CalculateSize(MultiMapInfoNotify._repeated_unlockBlockId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F304 RID: 62212 RVA: 0x00237828 File Offset: 0x00235A28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MultiMapInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.unlockMultiMapId_.Add(other.unlockMultiMapId_);
			this.unlockBlockId_.Add(other.unlockBlockId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F305 RID: 62213 RVA: 0x00237867 File Offset: 0x00235A67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F306 RID: 62214 RVA: 0x00237870 File Offset: 0x00235A70
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
					if (num == 16U || num == 18U)
					{
						this.unlockMultiMapId_.AddEntriesFrom(ref input, MultiMapInfoNotify._repeated_unlockMultiMapId_codec);
						continue;
					}
				}
				else if (num == 120U || num == 122U)
				{
					this.unlockBlockId_.AddEntriesFrom(ref input, MultiMapInfoNotify._repeated_unlockBlockId_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040061F4 RID: 25076
		private UnknownFieldSet _unknownFields;

		// Token: 0x040061F5 RID: 25077
		public const int UnlockMultiMapIdFieldNumber = 2;

		// Token: 0x040061F6 RID: 25078
		private static readonly FieldCodec<int> _repeated_unlockMultiMapId_codec = FieldCodec.ForInt32(18U);

		// Token: 0x040061F7 RID: 25079
		private readonly RepeatedField<int> unlockMultiMapId_ = new RepeatedField<int>();

		// Token: 0x040061F8 RID: 25080
		public const int UnlockBlockIdFieldNumber = 15;

		// Token: 0x040061F9 RID: 25081
		private static readonly FieldCodec<int> _repeated_unlockBlockId_codec = FieldCodec.ForInt32(122U);

		// Token: 0x040061FA RID: 25082
		private readonly RepeatedField<int> unlockBlockId_ = new RepeatedField<int>();
	}
}
