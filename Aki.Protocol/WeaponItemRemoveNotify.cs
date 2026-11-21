using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001566 RID: 5478
	[NetMessage(EMessageId.WeaponItemRemoveNotify)]
	public sealed class WeaponItemRemoveNotify : IMessage<WeaponItemRemoveNotify>, IMessage, IEquatable<WeaponItemRemoveNotify>, IDeepCloneable<WeaponItemRemoveNotify>, IBufferMessage
	{
		// Token: 0x0601D03C RID: 118844 RVA: 0x004340DF File Offset: 0x004322DF
		[NullableContext(1)]
		public static WeaponItemRemoveNotify Create()
		{
			return new WeaponItemRemoveNotify();
		}

		// Token: 0x17006230 RID: 25136
		// (get) Token: 0x0601D03D RID: 118845 RVA: 0x004340E6 File Offset: 0x004322E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006231 RID: 25137
		// (get) Token: 0x0601D03E RID: 118846 RVA: 0x004340E9 File Offset: 0x004322E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WeaponItemRemoveNotify.Descriptor;
			}
		}

		// Token: 0x0601D03F RID: 118847 RVA: 0x004340F0 File Offset: 0x004322F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponItemRemoveNotify()
		{
		}

		// Token: 0x0601D040 RID: 118848 RVA: 0x00434103 File Offset: 0x00432303
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponItemRemoveNotify(WeaponItemRemoveNotify other) : this()
		{
			this.weaponItemIncrIdList_ = other.weaponItemIncrIdList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D041 RID: 118849 RVA: 0x0043412D File Offset: 0x0043232D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponItemRemoveNotify Clone()
		{
			return new WeaponItemRemoveNotify(this);
		}

		// Token: 0x17006232 RID: 25138
		// (get) Token: 0x0601D042 RID: 118850 RVA: 0x00434135 File Offset: 0x00432335
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> WeaponItemIncrIdList
		{
			get
			{
				return this.weaponItemIncrIdList_;
			}
		}

		// Token: 0x0601D043 RID: 118851 RVA: 0x0043413D File Offset: 0x0043233D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WeaponItemRemoveNotify);
		}

		// Token: 0x0601D044 RID: 118852 RVA: 0x0043414B File Offset: 0x0043234B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WeaponItemRemoveNotify other)
		{
			return other != null && (other == this || (this.weaponItemIncrIdList_.Equals(other.weaponItemIncrIdList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D045 RID: 118853 RVA: 0x00434180 File Offset: 0x00432380
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.weaponItemIncrIdList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601D046 RID: 118854 RVA: 0x004341B4 File Offset: 0x004323B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D047 RID: 118855 RVA: 0x004341C1 File Offset: 0x004323C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D048 RID: 118856 RVA: 0x004341CA File Offset: 0x004323CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.weaponItemIncrIdList_.WriteTo(ref output, WeaponItemRemoveNotify._repeated_weaponItemIncrIdList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D049 RID: 118857 RVA: 0x004341F4 File Offset: 0x004323F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.weaponItemIncrIdList_.CalculateSize(WeaponItemRemoveNotify._repeated_weaponItemIncrIdList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601D04A RID: 118858 RVA: 0x0043422D File Offset: 0x0043242D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WeaponItemRemoveNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.weaponItemIncrIdList_.Add(other.weaponItemIncrIdList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601D04B RID: 118859 RVA: 0x0043425B File Offset: 0x0043245B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D04C RID: 118860 RVA: 0x00434264 File Offset: 0x00432464
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
				if (num != 56U && num != 58U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.weaponItemIncrIdList_.AddEntriesFrom(ref input, WeaponItemRemoveNotify._repeated_weaponItemIncrIdList_codec);
				}
			}
		}

		// Token: 0x0400A6BD RID: 42685
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A6BE RID: 42686
		public const int WeaponItemIncrIdListFieldNumber = 7;

		// Token: 0x0400A6BF RID: 42687
		private static readonly FieldCodec<int> _repeated_weaponItemIncrIdList_codec = FieldCodec.ForInt32(58U);

		// Token: 0x0400A6C0 RID: 42688
		private readonly RepeatedField<int> weaponItemIncrIdList_ = new RepeatedField<int>();
	}
}
