using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001408 RID: 5128
	public sealed class TrapDefenseAuxiliaryPbData : IMessage<TrapDefenseAuxiliaryPbData>, IMessage, IEquatable<TrapDefenseAuxiliaryPbData>, IDeepCloneable<TrapDefenseAuxiliaryPbData>, IBufferMessage
	{
		// Token: 0x0601B2F9 RID: 111353 RVA: 0x003F0C51 File Offset: 0x003EEE51
		[NullableContext(1)]
		public static TrapDefenseAuxiliaryPbData Create()
		{
			return new TrapDefenseAuxiliaryPbData();
		}

		// Token: 0x17005BB4 RID: 23476
		// (get) Token: 0x0601B2FA RID: 111354 RVA: 0x003F0C58 File Offset: 0x003EEE58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005BB5 RID: 23477
		// (get) Token: 0x0601B2FB RID: 111355 RVA: 0x003F0C5B File Offset: 0x003EEE5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseAuxiliaryPbData.Descriptor;
			}
		}

		// Token: 0x0601B2FC RID: 111356 RVA: 0x003F0C62 File Offset: 0x003EEE62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseAuxiliaryPbData()
		{
		}

		// Token: 0x0601B2FD RID: 111357 RVA: 0x003F0C75 File Offset: 0x003EEE75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseAuxiliaryPbData(TrapDefenseAuxiliaryPbData other) : this()
		{
			this.configIds_ = other.configIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B2FE RID: 111358 RVA: 0x003F0C9F File Offset: 0x003EEE9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseAuxiliaryPbData Clone()
		{
			return new TrapDefenseAuxiliaryPbData(this);
		}

		// Token: 0x17005BB6 RID: 23478
		// (get) Token: 0x0601B2FF RID: 111359 RVA: 0x003F0CA7 File Offset: 0x003EEEA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ConfigIds
		{
			get
			{
				return this.configIds_;
			}
		}

		// Token: 0x0601B300 RID: 111360 RVA: 0x003F0CAF File Offset: 0x003EEEAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseAuxiliaryPbData);
		}

		// Token: 0x0601B301 RID: 111361 RVA: 0x003F0CBD File Offset: 0x003EEEBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseAuxiliaryPbData other)
		{
			return other != null && (other == this || (this.configIds_.Equals(other.configIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B302 RID: 111362 RVA: 0x003F0CF0 File Offset: 0x003EEEF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.configIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B303 RID: 111363 RVA: 0x003F0D24 File Offset: 0x003EEF24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B304 RID: 111364 RVA: 0x003F0D31 File Offset: 0x003EEF31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B305 RID: 111365 RVA: 0x003F0D3A File Offset: 0x003EEF3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.configIds_.WriteTo(ref output, TrapDefenseAuxiliaryPbData._repeated_configIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B306 RID: 111366 RVA: 0x003F0D64 File Offset: 0x003EEF64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.configIds_.CalculateSize(TrapDefenseAuxiliaryPbData._repeated_configIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B307 RID: 111367 RVA: 0x003F0D9D File Offset: 0x003EEF9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseAuxiliaryPbData other)
		{
			if (other == null)
			{
				return;
			}
			this.configIds_.Add(other.configIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B308 RID: 111368 RVA: 0x003F0DCB File Offset: 0x003EEFCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B309 RID: 111369 RVA: 0x003F0DD4 File Offset: 0x003EEFD4
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
				if (num != 8U && num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.configIds_.AddEntriesFrom(ref input, TrapDefenseAuxiliaryPbData._repeated_configIds_codec);
				}
			}
		}

		// Token: 0x04009D52 RID: 40274
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009D53 RID: 40275
		public const int ConfigIdsFieldNumber = 1;

		// Token: 0x04009D54 RID: 40276
		private static readonly FieldCodec<int> _repeated_configIds_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04009D55 RID: 40277
		private readonly RepeatedField<int> configIds_ = new RepeatedField<int>();
	}
}
