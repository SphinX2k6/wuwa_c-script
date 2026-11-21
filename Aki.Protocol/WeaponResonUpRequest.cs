using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200156C RID: 5484
	[NetMessage(EMessageId.WeaponResonUpRequest)]
	public sealed class WeaponResonUpRequest : IMessage<WeaponResonUpRequest>, IMessage, IEquatable<WeaponResonUpRequest>, IDeepCloneable<WeaponResonUpRequest>, IBufferMessage
	{
		// Token: 0x0601D0B0 RID: 118960 RVA: 0x00434F15 File Offset: 0x00433115
		[NullableContext(1)]
		public static WeaponResonUpRequest Create()
		{
			return new WeaponResonUpRequest();
		}

		// Token: 0x17006246 RID: 25158
		// (get) Token: 0x0601D0B1 RID: 118961 RVA: 0x00434F1C File Offset: 0x0043311C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006247 RID: 25159
		// (get) Token: 0x0601D0B2 RID: 118962 RVA: 0x00434F1F File Offset: 0x0043311F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WeaponResonUpRequest.Descriptor;
			}
		}

		// Token: 0x0601D0B3 RID: 118963 RVA: 0x00434F26 File Offset: 0x00433126
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponResonUpRequest()
		{
		}

		// Token: 0x0601D0B4 RID: 118964 RVA: 0x00434F44 File Offset: 0x00433144
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponResonUpRequest(WeaponResonUpRequest other) : this()
		{
			this.incId_ = other.incId_;
			this.consumeList_ = other.consumeList_.Clone();
			this.consumeItemList_ = other.consumeItemList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D0B5 RID: 118965 RVA: 0x00434F96 File Offset: 0x00433196
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponResonUpRequest Clone()
		{
			return new WeaponResonUpRequest(this);
		}

		// Token: 0x17006248 RID: 25160
		// (get) Token: 0x0601D0B6 RID: 118966 RVA: 0x00434F9E File Offset: 0x0043319E
		// (set) Token: 0x0601D0B7 RID: 118967 RVA: 0x00434FA6 File Offset: 0x004331A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncId
		{
			get
			{
				return this.incId_;
			}
			set
			{
				this.incId_ = value;
			}
		}

		// Token: 0x17006249 RID: 25161
		// (get) Token: 0x0601D0B8 RID: 118968 RVA: 0x00434FAF File Offset: 0x004331AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ConsumeList
		{
			get
			{
				return this.consumeList_;
			}
		}

		// Token: 0x1700624A RID: 25162
		// (get) Token: 0x0601D0B9 RID: 118969 RVA: 0x00434FB7 File Offset: 0x004331B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<WeaponConsumeItem> ConsumeItemList
		{
			get
			{
				return this.consumeItemList_;
			}
		}

		// Token: 0x0601D0BA RID: 118970 RVA: 0x00434FBF File Offset: 0x004331BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WeaponResonUpRequest);
		}

		// Token: 0x0601D0BB RID: 118971 RVA: 0x00434FD0 File Offset: 0x004331D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WeaponResonUpRequest other)
		{
			return other != null && (other == this || (this.IncId == other.IncId && this.consumeList_.Equals(other.consumeList_) && this.consumeItemList_.Equals(other.consumeItemList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D0BC RID: 118972 RVA: 0x00435034 File Offset: 0x00433234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IncId != 0)
			{
				num ^= this.IncId.GetHashCode();
			}
			num ^= this.consumeList_.GetHashCode();
			num ^= this.consumeItemList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601D0BD RID: 118973 RVA: 0x0043508F File Offset: 0x0043328F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D0BE RID: 118974 RVA: 0x0043509C File Offset: 0x0043329C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D0BF RID: 118975 RVA: 0x004350A8 File Offset: 0x004332A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IncId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.IncId);
			}
			this.consumeList_.WriteTo(ref output, WeaponResonUpRequest._repeated_consumeList_codec);
			this.consumeItemList_.WriteTo(ref output, WeaponResonUpRequest._repeated_consumeItemList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D0C0 RID: 118976 RVA: 0x00435108 File Offset: 0x00433308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncId);
			}
			num += this.consumeList_.CalculateSize(WeaponResonUpRequest._repeated_consumeList_codec);
			num += this.consumeItemList_.CalculateSize(WeaponResonUpRequest._repeated_consumeItemList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601D0C1 RID: 118977 RVA: 0x0043516C File Offset: 0x0043336C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WeaponResonUpRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IncId != 0)
			{
				this.IncId = other.IncId;
			}
			this.consumeList_.Add(other.consumeList_);
			this.consumeItemList_.Add(other.consumeItemList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601D0C2 RID: 118978 RVA: 0x004351CA File Offset: 0x004333CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D0C3 RID: 118979 RVA: 0x004351D4 File Offset: 0x004333D4
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.IncId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						goto IL_45;
					}
				}
				else
				{
					if (num == 18U)
					{
						goto IL_45;
					}
					if (num == 50U)
					{
						this.consumeItemList_.AddEntriesFrom(ref input, WeaponResonUpRequest._repeated_consumeItemList_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_45:
				this.consumeList_.AddEntriesFrom(ref input, WeaponResonUpRequest._repeated_consumeList_codec);
			}
		}

		// Token: 0x0400A6DB RID: 42715
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A6DC RID: 42716
		public const int IncIdFieldNumber = 1;

		// Token: 0x0400A6DD RID: 42717
		private int incId_;

		// Token: 0x0400A6DE RID: 42718
		public const int ConsumeListFieldNumber = 2;

		// Token: 0x0400A6DF RID: 42719
		private static readonly FieldCodec<int> _repeated_consumeList_codec = FieldCodec.ForInt32(18U);

		// Token: 0x0400A6E0 RID: 42720
		private readonly RepeatedField<int> consumeList_ = new RepeatedField<int>();

		// Token: 0x0400A6E1 RID: 42721
		public const int ConsumeItemListFieldNumber = 6;

		// Token: 0x0400A6E2 RID: 42722
		private static readonly FieldCodec<WeaponConsumeItem> _repeated_consumeItemList_codec = FieldCodec.ForMessage<WeaponConsumeItem>(50U, WeaponConsumeItem.Parser);

		// Token: 0x0400A6E3 RID: 42723
		private readonly RepeatedField<WeaponConsumeItem> consumeItemList_ = new RepeatedField<WeaponConsumeItem>();
	}
}
