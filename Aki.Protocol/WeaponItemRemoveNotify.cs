using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014F0 RID: 5360
	[NetMessage(EMessageId.WeaponItemRemoveNotify)]
	public sealed class WeaponItemRemoveNotify : IMessage<WeaponItemRemoveNotify>, IMessage, IEquatable<WeaponItemRemoveNotify>, IDeepCloneable<WeaponItemRemoveNotify>, IBufferMessage
	{
		// Token: 0x0601C575 RID: 116085 RVA: 0x00418623 File Offset: 0x00416823
		[NullableContext(1)]
		public static WeaponItemRemoveNotify Create()
		{
			return new WeaponItemRemoveNotify();
		}

		// Token: 0x17005F8F RID: 24463
		// (get) Token: 0x0601C576 RID: 116086 RVA: 0x0041862A File Offset: 0x0041682A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005F90 RID: 24464
		// (get) Token: 0x0601C577 RID: 116087 RVA: 0x0041862D File Offset: 0x0041682D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WeaponItemRemoveNotify.Descriptor;
			}
		}

		// Token: 0x0601C578 RID: 116088 RVA: 0x00418634 File Offset: 0x00416834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponItemRemoveNotify()
		{
		}

		// Token: 0x0601C579 RID: 116089 RVA: 0x00418647 File Offset: 0x00416847
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponItemRemoveNotify(WeaponItemRemoveNotify other) : this()
		{
			this.weaponItemIncrIdList_ = other.weaponItemIncrIdList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C57A RID: 116090 RVA: 0x00418671 File Offset: 0x00416871
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponItemRemoveNotify Clone()
		{
			return new WeaponItemRemoveNotify(this);
		}

		// Token: 0x17005F91 RID: 24465
		// (get) Token: 0x0601C57B RID: 116091 RVA: 0x00418679 File Offset: 0x00416879
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> WeaponItemIncrIdList
		{
			get
			{
				return this.weaponItemIncrIdList_;
			}
		}

		// Token: 0x0601C57C RID: 116092 RVA: 0x00418681 File Offset: 0x00416881
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WeaponItemRemoveNotify);
		}

		// Token: 0x0601C57D RID: 116093 RVA: 0x0041868F File Offset: 0x0041688F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WeaponItemRemoveNotify other)
		{
			return other != null && (other == this || (this.weaponItemIncrIdList_.Equals(other.weaponItemIncrIdList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C57E RID: 116094 RVA: 0x004186C4 File Offset: 0x004168C4
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

		// Token: 0x0601C57F RID: 116095 RVA: 0x004186F8 File Offset: 0x004168F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C580 RID: 116096 RVA: 0x00418705 File Offset: 0x00416905
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C581 RID: 116097 RVA: 0x0041870E File Offset: 0x0041690E
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

		// Token: 0x0601C582 RID: 116098 RVA: 0x00418738 File Offset: 0x00416938
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

		// Token: 0x0601C583 RID: 116099 RVA: 0x00418771 File Offset: 0x00416971
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

		// Token: 0x0601C584 RID: 116100 RVA: 0x0041879F File Offset: 0x0041699F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C585 RID: 116101 RVA: 0x004187A8 File Offset: 0x004169A8
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
				if (num != 112U && num != 114U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.weaponItemIncrIdList_.AddEntriesFrom(ref input, WeaponItemRemoveNotify._repeated_weaponItemIncrIdList_codec);
				}
			}
		}

		// Token: 0x0400A264 RID: 41572
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A265 RID: 41573
		public const int WeaponItemIncrIdListFieldNumber = 14;

		// Token: 0x0400A266 RID: 41574
		private static readonly FieldCodec<int> _repeated_weaponItemIncrIdList_codec = FieldCodec.ForInt32(114U);

		// Token: 0x0400A267 RID: 41575
		private readonly RepeatedField<int> weaponItemIncrIdList_ = new RepeatedField<int>();
	}
}
