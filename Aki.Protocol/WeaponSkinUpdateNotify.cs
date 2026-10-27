using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014FB RID: 5371
	[NetMessage(EMessageId.WeaponSkinUpdateNotify)]
	public sealed class WeaponSkinUpdateNotify : IMessage<WeaponSkinUpdateNotify>, IMessage, IEquatable<WeaponSkinUpdateNotify>, IDeepCloneable<WeaponSkinUpdateNotify>, IBufferMessage
	{
		// Token: 0x0601C64E RID: 116302 RVA: 0x0041A260 File Offset: 0x00418460
		[NullableContext(1)]
		public static WeaponSkinUpdateNotify Create()
		{
			return new WeaponSkinUpdateNotify();
		}

		// Token: 0x17005FBA RID: 24506
		// (get) Token: 0x0601C64F RID: 116303 RVA: 0x0041A267 File Offset: 0x00418467
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005FBB RID: 24507
		// (get) Token: 0x0601C650 RID: 116304 RVA: 0x0041A26A File Offset: 0x0041846A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WeaponSkinUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0601C651 RID: 116305 RVA: 0x0041A271 File Offset: 0x00418471
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponSkinUpdateNotify()
		{
		}

		// Token: 0x0601C652 RID: 116306 RVA: 0x0041A284 File Offset: 0x00418484
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponSkinUpdateNotify(WeaponSkinUpdateNotify other) : this()
		{
			this.skinIds_ = other.skinIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C653 RID: 116307 RVA: 0x0041A2AE File Offset: 0x004184AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponSkinUpdateNotify Clone()
		{
			return new WeaponSkinUpdateNotify(this);
		}

		// Token: 0x17005FBC RID: 24508
		// (get) Token: 0x0601C654 RID: 116308 RVA: 0x0041A2B6 File Offset: 0x004184B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SkinIds
		{
			get
			{
				return this.skinIds_;
			}
		}

		// Token: 0x0601C655 RID: 116309 RVA: 0x0041A2BE File Offset: 0x004184BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WeaponSkinUpdateNotify);
		}

		// Token: 0x0601C656 RID: 116310 RVA: 0x0041A2CC File Offset: 0x004184CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WeaponSkinUpdateNotify other)
		{
			return other != null && (other == this || (this.skinIds_.Equals(other.skinIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C657 RID: 116311 RVA: 0x0041A300 File Offset: 0x00418500
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.skinIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C658 RID: 116312 RVA: 0x0041A334 File Offset: 0x00418534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C659 RID: 116313 RVA: 0x0041A341 File Offset: 0x00418541
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C65A RID: 116314 RVA: 0x0041A34A File Offset: 0x0041854A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.skinIds_.WriteTo(ref output, WeaponSkinUpdateNotify._repeated_skinIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C65B RID: 116315 RVA: 0x0041A374 File Offset: 0x00418574
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.skinIds_.CalculateSize(WeaponSkinUpdateNotify._repeated_skinIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C65C RID: 116316 RVA: 0x0041A3AD File Offset: 0x004185AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WeaponSkinUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.skinIds_.Add(other.skinIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C65D RID: 116317 RVA: 0x0041A3DB File Offset: 0x004185DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C65E RID: 116318 RVA: 0x0041A3E4 File Offset: 0x004185E4
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
				if (num != 40U && num != 42U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.skinIds_.AddEntriesFrom(ref input, WeaponSkinUpdateNotify._repeated_skinIds_codec);
				}
			}
		}

		// Token: 0x0400A2A0 RID: 41632
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A2A1 RID: 41633
		public const int SkinIdsFieldNumber = 5;

		// Token: 0x0400A2A2 RID: 41634
		private static readonly FieldCodec<int> _repeated_skinIds_codec = FieldCodec.ForInt32(42U);

		// Token: 0x0400A2A3 RID: 41635
		private readonly RepeatedField<int> skinIds_ = new RepeatedField<int>();
	}
}
