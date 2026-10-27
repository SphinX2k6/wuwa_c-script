using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007BF RID: 1983
	public sealed class ICustomScreenLoadingPb : IMessage<ICustomScreenLoadingPb>, IMessage, IEquatable<ICustomScreenLoadingPb>, IDeepCloneable<ICustomScreenLoadingPb>, IBufferMessage
	{
		// Token: 0x0600B267 RID: 45671 RVA: 0x001AB25A File Offset: 0x001A945A
		[NullableContext(1)]
		public static ICustomScreenLoadingPb Create()
		{
			return new ICustomScreenLoadingPb();
		}

		// Token: 0x170023FB RID: 9211
		// (get) Token: 0x0600B268 RID: 45672 RVA: 0x001AB261 File Offset: 0x001A9461
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170023FC RID: 9212
		// (get) Token: 0x0600B269 RID: 45673 RVA: 0x001AB264 File Offset: 0x001A9464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ICustomScreenLoadingPb.Descriptor;
			}
		}

		// Token: 0x0600B26A RID: 45674 RVA: 0x001AB26B File Offset: 0x001A946B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ICustomScreenLoadingPb()
		{
		}

		// Token: 0x0600B26B RID: 45675 RVA: 0x001AB273 File Offset: 0x001A9473
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ICustomScreenLoadingPb(ICustomScreenLoadingPb other) : this()
		{
			if (other.LoadingTypeCase == ICustomScreenLoadingPb.LoadingTypeOneofCase.ICustomScreenLoadingCyberpunkPb)
			{
				this.ICustomScreenLoadingCyberpunkPb = other.ICustomScreenLoadingCyberpunkPb.Clone();
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B26C RID: 45676 RVA: 0x001AB2A6 File Offset: 0x001A94A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ICustomScreenLoadingPb Clone()
		{
			return new ICustomScreenLoadingPb(this);
		}

		// Token: 0x170023FD RID: 9213
		// (get) Token: 0x0600B26D RID: 45677 RVA: 0x001AB2AE File Offset: 0x001A94AE
		// (set) Token: 0x0600B26E RID: 45678 RVA: 0x001AB2C6 File Offset: 0x001A94C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ICustomScreenLoadingCyberpunkPb ICustomScreenLoadingCyberpunkPb
		{
			get
			{
				if (this.loadingTypeCase_ != ICustomScreenLoadingPb.LoadingTypeOneofCase.ICustomScreenLoadingCyberpunkPb)
				{
					return null;
				}
				return (ICustomScreenLoadingCyberpunkPb)this.loadingType_;
			}
			set
			{
				this.loadingType_ = value;
				this.loadingTypeCase_ = ((value == null) ? ICustomScreenLoadingPb.LoadingTypeOneofCase.None : ICustomScreenLoadingPb.LoadingTypeOneofCase.ICustomScreenLoadingCyberpunkPb);
			}
		}

		// Token: 0x170023FE RID: 9214
		// (get) Token: 0x0600B26F RID: 45679 RVA: 0x001AB2DC File Offset: 0x001A94DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ICustomScreenLoadingPb.LoadingTypeOneofCase LoadingTypeCase
		{
			get
			{
				return this.loadingTypeCase_;
			}
		}

		// Token: 0x0600B270 RID: 45680 RVA: 0x001AB2E4 File Offset: 0x001A94E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearLoadingType()
		{
			this.loadingTypeCase_ = ICustomScreenLoadingPb.LoadingTypeOneofCase.None;
			this.loadingType_ = null;
		}

		// Token: 0x0600B271 RID: 45681 RVA: 0x001AB2F4 File Offset: 0x001A94F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ICustomScreenLoadingPb);
		}

		// Token: 0x0600B272 RID: 45682 RVA: 0x001AB304 File Offset: 0x001A9504
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ICustomScreenLoadingPb other)
		{
			return other != null && (other == this || (object.Equals(this.ICustomScreenLoadingCyberpunkPb, other.ICustomScreenLoadingCyberpunkPb) && this.LoadingTypeCase == other.LoadingTypeCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B273 RID: 45683 RVA: 0x001AB354 File Offset: 0x001A9554
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.loadingTypeCase_ == ICustomScreenLoadingPb.LoadingTypeOneofCase.ICustomScreenLoadingCyberpunkPb)
			{
				num ^= this.ICustomScreenLoadingCyberpunkPb.GetHashCode();
			}
			num ^= (int)this.loadingTypeCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B274 RID: 45684 RVA: 0x001AB39A File Offset: 0x001A959A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B275 RID: 45685 RVA: 0x001AB3A7 File Offset: 0x001A95A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B276 RID: 45686 RVA: 0x001AB3B0 File Offset: 0x001A95B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.loadingTypeCase_ == ICustomScreenLoadingPb.LoadingTypeOneofCase.ICustomScreenLoadingCyberpunkPb)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.ICustomScreenLoadingCyberpunkPb);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B277 RID: 45687 RVA: 0x001AB3E4 File Offset: 0x001A95E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.loadingTypeCase_ == ICustomScreenLoadingPb.LoadingTypeOneofCase.ICustomScreenLoadingCyberpunkPb)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ICustomScreenLoadingCyberpunkPb);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B278 RID: 45688 RVA: 0x001AB424 File Offset: 0x001A9624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ICustomScreenLoadingPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LoadingTypeCase == ICustomScreenLoadingPb.LoadingTypeOneofCase.ICustomScreenLoadingCyberpunkPb)
			{
				if (this.ICustomScreenLoadingCyberpunkPb == null)
				{
					this.ICustomScreenLoadingCyberpunkPb = new ICustomScreenLoadingCyberpunkPb();
				}
				this.ICustomScreenLoadingCyberpunkPb.MergeFrom(other.ICustomScreenLoadingCyberpunkPb);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B279 RID: 45689 RVA: 0x001AB479 File Offset: 0x001A9679
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B27A RID: 45690 RVA: 0x001AB484 File Offset: 0x001A9684
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					ICustomScreenLoadingCyberpunkPb customScreenLoadingCyberpunkPb = new ICustomScreenLoadingCyberpunkPb();
					if (this.loadingTypeCase_ == ICustomScreenLoadingPb.LoadingTypeOneofCase.ICustomScreenLoadingCyberpunkPb)
					{
						customScreenLoadingCyberpunkPb.MergeFrom(this.ICustomScreenLoadingCyberpunkPb);
					}
					input.ReadMessage(customScreenLoadingCyberpunkPb);
					this.ICustomScreenLoadingCyberpunkPb = customScreenLoadingCyberpunkPb;
				}
			}
		}

		// Token: 0x04004FBF RID: 20415
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004FC0 RID: 20416
		public const int ICustomScreenLoadingCyberpunkPbFieldNumber = 1;

		// Token: 0x04004FC1 RID: 20417
		private object loadingType_;

		// Token: 0x04004FC2 RID: 20418
		private ICustomScreenLoadingPb.LoadingTypeOneofCase loadingTypeCase_;

		// Token: 0x020017F2 RID: 6130
		public enum LoadingTypeOneofCase
		{
			// Token: 0x0400C794 RID: 51092
			None,
			// Token: 0x0400C795 RID: 51093
			ICustomScreenLoadingCyberpunkPb
		}
	}
}
