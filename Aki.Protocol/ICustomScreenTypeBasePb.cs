using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007AE RID: 1966
	public sealed class ICustomScreenTypeBasePb : IMessage<ICustomScreenTypeBasePb>, IMessage, IEquatable<ICustomScreenTypeBasePb>, IDeepCloneable<ICustomScreenTypeBasePb>, IBufferMessage
	{
		// Token: 0x0600B154 RID: 45396 RVA: 0x001A908A File Offset: 0x001A728A
		[NullableContext(1)]
		public static ICustomScreenTypeBasePb Create()
		{
			return new ICustomScreenTypeBasePb();
		}

		// Token: 0x170023C0 RID: 9152
		// (get) Token: 0x0600B155 RID: 45397 RVA: 0x001A9091 File Offset: 0x001A7291
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170023C1 RID: 9153
		// (get) Token: 0x0600B156 RID: 45398 RVA: 0x001A9094 File Offset: 0x001A7294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ICustomScreenTypeBasePb.Descriptor;
			}
		}

		// Token: 0x0600B157 RID: 45399 RVA: 0x001A909B File Offset: 0x001A729B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ICustomScreenTypeBasePb()
		{
		}

		// Token: 0x0600B158 RID: 45400 RVA: 0x001A90A4 File Offset: 0x001A72A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ICustomScreenTypeBasePb(ICustomScreenTypeBasePb other) : this()
		{
			switch (other.ScreenPbCase)
			{
			case ICustomScreenTypeBasePb.ScreenPbOneofCase.ICustomScreenSpinePb:
				this.ICustomScreenSpinePb = other.ICustomScreenSpinePb.Clone();
				break;
			case ICustomScreenTypeBasePb.ScreenPbOneofCase.ICustomScreenBackgroundImagePb:
				this.ICustomScreenBackgroundImagePb = other.ICustomScreenBackgroundImagePb.Clone();
				break;
			case ICustomScreenTypeBasePb.ScreenPbOneofCase.ICustomScreenLoadingPb:
				this.ICustomScreenLoadingPb = other.ICustomScreenLoadingPb.Clone();
				break;
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B159 RID: 45401 RVA: 0x001A911C File Offset: 0x001A731C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ICustomScreenTypeBasePb Clone()
		{
			return new ICustomScreenTypeBasePb(this);
		}

		// Token: 0x170023C2 RID: 9154
		// (get) Token: 0x0600B15A RID: 45402 RVA: 0x001A9124 File Offset: 0x001A7324
		// (set) Token: 0x0600B15B RID: 45403 RVA: 0x001A913C File Offset: 0x001A733C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ICustomScreenSpinePb ICustomScreenSpinePb
		{
			get
			{
				if (this.screenPbCase_ != ICustomScreenTypeBasePb.ScreenPbOneofCase.ICustomScreenSpinePb)
				{
					return null;
				}
				return (ICustomScreenSpinePb)this.screenPb_;
			}
			set
			{
				this.screenPb_ = value;
				this.screenPbCase_ = ((value == null) ? ICustomScreenTypeBasePb.ScreenPbOneofCase.None : ICustomScreenTypeBasePb.ScreenPbOneofCase.ICustomScreenSpinePb);
			}
		}

		// Token: 0x170023C3 RID: 9155
		// (get) Token: 0x0600B15C RID: 45404 RVA: 0x001A9152 File Offset: 0x001A7352
		// (set) Token: 0x0600B15D RID: 45405 RVA: 0x001A916A File Offset: 0x001A736A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ICustomScreenBackgroundImagePb ICustomScreenBackgroundImagePb
		{
			get
			{
				if (this.screenPbCase_ != ICustomScreenTypeBasePb.ScreenPbOneofCase.ICustomScreenBackgroundImagePb)
				{
					return null;
				}
				return (ICustomScreenBackgroundImagePb)this.screenPb_;
			}
			set
			{
				this.screenPb_ = value;
				this.screenPbCase_ = ((value == null) ? ICustomScreenTypeBasePb.ScreenPbOneofCase.None : ICustomScreenTypeBasePb.ScreenPbOneofCase.ICustomScreenBackgroundImagePb);
			}
		}

		// Token: 0x170023C4 RID: 9156
		// (get) Token: 0x0600B15E RID: 45406 RVA: 0x001A9180 File Offset: 0x001A7380
		// (set) Token: 0x0600B15F RID: 45407 RVA: 0x001A9198 File Offset: 0x001A7398
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ICustomScreenLoadingPb ICustomScreenLoadingPb
		{
			get
			{
				if (this.screenPbCase_ != ICustomScreenTypeBasePb.ScreenPbOneofCase.ICustomScreenLoadingPb)
				{
					return null;
				}
				return (ICustomScreenLoadingPb)this.screenPb_;
			}
			set
			{
				this.screenPb_ = value;
				this.screenPbCase_ = ((value == null) ? ICustomScreenTypeBasePb.ScreenPbOneofCase.None : ICustomScreenTypeBasePb.ScreenPbOneofCase.ICustomScreenLoadingPb);
			}
		}

		// Token: 0x170023C5 RID: 9157
		// (get) Token: 0x0600B160 RID: 45408 RVA: 0x001A91AE File Offset: 0x001A73AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ICustomScreenTypeBasePb.ScreenPbOneofCase ScreenPbCase
		{
			get
			{
				return this.screenPbCase_;
			}
		}

		// Token: 0x0600B161 RID: 45409 RVA: 0x001A91B6 File Offset: 0x001A73B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearScreenPb()
		{
			this.screenPbCase_ = ICustomScreenTypeBasePb.ScreenPbOneofCase.None;
			this.screenPb_ = null;
		}

		// Token: 0x0600B162 RID: 45410 RVA: 0x001A91C6 File Offset: 0x001A73C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ICustomScreenTypeBasePb);
		}

		// Token: 0x0600B163 RID: 45411 RVA: 0x001A91D4 File Offset: 0x001A73D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ICustomScreenTypeBasePb other)
		{
			return other != null && (other == this || (object.Equals(this.ICustomScreenSpinePb, other.ICustomScreenSpinePb) && object.Equals(this.ICustomScreenBackgroundImagePb, other.ICustomScreenBackgroundImagePb) && object.Equals(this.ICustomScreenLoadingPb, other.ICustomScreenLoadingPb) && this.ScreenPbCase == other.ScreenPbCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B164 RID: 45412 RVA: 0x001A924C File Offset: 0x001A744C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.screenPbCase_ == ICustomScreenTypeBasePb.ScreenPbOneofCase.ICustomScreenSpinePb)
			{
				num ^= this.ICustomScreenSpinePb.GetHashCode();
			}
			if (this.screenPbCase_ == ICustomScreenTypeBasePb.ScreenPbOneofCase.ICustomScreenBackgroundImagePb)
			{
				num ^= this.ICustomScreenBackgroundImagePb.GetHashCode();
			}
			if (this.screenPbCase_ == ICustomScreenTypeBasePb.ScreenPbOneofCase.ICustomScreenLoadingPb)
			{
				num ^= this.ICustomScreenLoadingPb.GetHashCode();
			}
			num ^= (int)this.screenPbCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B165 RID: 45413 RVA: 0x001A92C0 File Offset: 0x001A74C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B166 RID: 45414 RVA: 0x001A92CD File Offset: 0x001A74CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B167 RID: 45415 RVA: 0x001A92D8 File Offset: 0x001A74D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.screenPbCase_ == ICustomScreenTypeBasePb.ScreenPbOneofCase.ICustomScreenSpinePb)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.ICustomScreenSpinePb);
			}
			if (this.screenPbCase_ == ICustomScreenTypeBasePb.ScreenPbOneofCase.ICustomScreenBackgroundImagePb)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.ICustomScreenBackgroundImagePb);
			}
			if (this.screenPbCase_ == ICustomScreenTypeBasePb.ScreenPbOneofCase.ICustomScreenLoadingPb)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.ICustomScreenLoadingPb);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B168 RID: 45416 RVA: 0x001A9350 File Offset: 0x001A7550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.screenPbCase_ == ICustomScreenTypeBasePb.ScreenPbOneofCase.ICustomScreenSpinePb)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ICustomScreenSpinePb);
			}
			if (this.screenPbCase_ == ICustomScreenTypeBasePb.ScreenPbOneofCase.ICustomScreenBackgroundImagePb)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ICustomScreenBackgroundImagePb);
			}
			if (this.screenPbCase_ == ICustomScreenTypeBasePb.ScreenPbOneofCase.ICustomScreenLoadingPb)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ICustomScreenLoadingPb);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B169 RID: 45417 RVA: 0x001A93C4 File Offset: 0x001A75C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ICustomScreenTypeBasePb other)
		{
			if (other == null)
			{
				return;
			}
			switch (other.ScreenPbCase)
			{
			case ICustomScreenTypeBasePb.ScreenPbOneofCase.ICustomScreenSpinePb:
				if (this.ICustomScreenSpinePb == null)
				{
					this.ICustomScreenSpinePb = new ICustomScreenSpinePb();
				}
				this.ICustomScreenSpinePb.MergeFrom(other.ICustomScreenSpinePb);
				break;
			case ICustomScreenTypeBasePb.ScreenPbOneofCase.ICustomScreenBackgroundImagePb:
				if (this.ICustomScreenBackgroundImagePb == null)
				{
					this.ICustomScreenBackgroundImagePb = new ICustomScreenBackgroundImagePb();
				}
				this.ICustomScreenBackgroundImagePb.MergeFrom(other.ICustomScreenBackgroundImagePb);
				break;
			case ICustomScreenTypeBasePb.ScreenPbOneofCase.ICustomScreenLoadingPb:
				if (this.ICustomScreenLoadingPb == null)
				{
					this.ICustomScreenLoadingPb = new ICustomScreenLoadingPb();
				}
				this.ICustomScreenLoadingPb.MergeFrom(other.ICustomScreenLoadingPb);
				break;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B16A RID: 45418 RVA: 0x001A9479 File Offset: 0x001A7679
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B16B RID: 45419 RVA: 0x001A9484 File Offset: 0x001A7684
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
				if (num != 10U)
				{
					if (num != 18U)
					{
						if (num != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							ICustomScreenLoadingPb customScreenLoadingPb = new ICustomScreenLoadingPb();
							if (this.screenPbCase_ == ICustomScreenTypeBasePb.ScreenPbOneofCase.ICustomScreenLoadingPb)
							{
								customScreenLoadingPb.MergeFrom(this.ICustomScreenLoadingPb);
							}
							input.ReadMessage(customScreenLoadingPb);
							this.ICustomScreenLoadingPb = customScreenLoadingPb;
						}
					}
					else
					{
						ICustomScreenBackgroundImagePb customScreenBackgroundImagePb = new ICustomScreenBackgroundImagePb();
						if (this.screenPbCase_ == ICustomScreenTypeBasePb.ScreenPbOneofCase.ICustomScreenBackgroundImagePb)
						{
							customScreenBackgroundImagePb.MergeFrom(this.ICustomScreenBackgroundImagePb);
						}
						input.ReadMessage(customScreenBackgroundImagePb);
						this.ICustomScreenBackgroundImagePb = customScreenBackgroundImagePb;
					}
				}
				else
				{
					ICustomScreenSpinePb customScreenSpinePb = new ICustomScreenSpinePb();
					if (this.screenPbCase_ == ICustomScreenTypeBasePb.ScreenPbOneofCase.ICustomScreenSpinePb)
					{
						customScreenSpinePb.MergeFrom(this.ICustomScreenSpinePb);
					}
					input.ReadMessage(customScreenSpinePb);
					this.ICustomScreenSpinePb = customScreenSpinePb;
				}
			}
		}

		// Token: 0x04004FCA RID: 20426
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004FCB RID: 20427
		public const int ICustomScreenSpinePbFieldNumber = 1;

		// Token: 0x04004FCC RID: 20428
		public const int ICustomScreenBackgroundImagePbFieldNumber = 2;

		// Token: 0x04004FCD RID: 20429
		public const int ICustomScreenLoadingPbFieldNumber = 3;

		// Token: 0x04004FCE RID: 20430
		private object screenPb_;

		// Token: 0x04004FCF RID: 20431
		private ICustomScreenTypeBasePb.ScreenPbOneofCase screenPbCase_;

		// Token: 0x0200186B RID: 6251
		public enum ScreenPbOneofCase
		{
			// Token: 0x0400CCC2 RID: 52418
			None,
			// Token: 0x0400CCC3 RID: 52419
			ICustomScreenSpinePb,
			// Token: 0x0400CCC4 RID: 52420
			ICustomScreenBackgroundImagePb,
			// Token: 0x0400CCC5 RID: 52421
			ICustomScreenLoadingPb
		}
	}
}
