using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007A9 RID: 1961
	public sealed class ICustomScreenBackgroundImagePb : IMessage<ICustomScreenBackgroundImagePb>, IMessage, IEquatable<ICustomScreenBackgroundImagePb>, IDeepCloneable<ICustomScreenBackgroundImagePb>, IBufferMessage
	{
		// Token: 0x0600B0EF RID: 45295 RVA: 0x001A84E8 File Offset: 0x001A66E8
		[NullableContext(1)]
		public static ICustomScreenBackgroundImagePb Create()
		{
			return new ICustomScreenBackgroundImagePb();
		}

		// Token: 0x170023AC RID: 9132
		// (get) Token: 0x0600B0F0 RID: 45296 RVA: 0x001A84EF File Offset: 0x001A66EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170023AD RID: 9133
		// (get) Token: 0x0600B0F1 RID: 45297 RVA: 0x001A84F2 File Offset: 0x001A66F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ICustomScreenBackgroundImagePb.Descriptor;
			}
		}

		// Token: 0x0600B0F2 RID: 45298 RVA: 0x001A84F9 File Offset: 0x001A66F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ICustomScreenBackgroundImagePb()
		{
		}

		// Token: 0x0600B0F3 RID: 45299 RVA: 0x001A850C File Offset: 0x001A670C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ICustomScreenBackgroundImagePb(ICustomScreenBackgroundImagePb other) : this()
		{
			this.backgroundImagePath_ = other.backgroundImagePath_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B0F4 RID: 45300 RVA: 0x001A8531 File Offset: 0x001A6731
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ICustomScreenBackgroundImagePb Clone()
		{
			return new ICustomScreenBackgroundImagePb(this);
		}

		// Token: 0x170023AE RID: 9134
		// (get) Token: 0x0600B0F5 RID: 45301 RVA: 0x001A8539 File Offset: 0x001A6739
		// (set) Token: 0x0600B0F6 RID: 45302 RVA: 0x001A8541 File Offset: 0x001A6741
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string BackgroundImagePath
		{
			get
			{
				return this.backgroundImagePath_;
			}
			set
			{
				this.backgroundImagePath_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x0600B0F7 RID: 45303 RVA: 0x001A8554 File Offset: 0x001A6754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ICustomScreenBackgroundImagePb);
		}

		// Token: 0x0600B0F8 RID: 45304 RVA: 0x001A8562 File Offset: 0x001A6762
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ICustomScreenBackgroundImagePb other)
		{
			return other != null && (other == this || (!(this.BackgroundImagePath != other.BackgroundImagePath) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B0F9 RID: 45305 RVA: 0x001A8598 File Offset: 0x001A6798
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BackgroundImagePath.Length != 0)
			{
				num ^= this.BackgroundImagePath.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B0FA RID: 45306 RVA: 0x001A85D9 File Offset: 0x001A67D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B0FB RID: 45307 RVA: 0x001A85E6 File Offset: 0x001A67E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B0FC RID: 45308 RVA: 0x001A85EF File Offset: 0x001A67EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BackgroundImagePath.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(this.BackgroundImagePath);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B0FD RID: 45309 RVA: 0x001A8628 File Offset: 0x001A6828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BackgroundImagePath.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.BackgroundImagePath);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B0FE RID: 45310 RVA: 0x001A866B File Offset: 0x001A686B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ICustomScreenBackgroundImagePb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BackgroundImagePath.Length != 0)
			{
				this.BackgroundImagePath = other.BackgroundImagePath;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B0FF RID: 45311 RVA: 0x001A86A1 File Offset: 0x001A68A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B100 RID: 45312 RVA: 0x001A86AC File Offset: 0x001A68AC
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
					this.BackgroundImagePath = input.ReadString();
				}
			}
		}

		// Token: 0x04004FB4 RID: 20404
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004FB5 RID: 20405
		public const int BackgroundImagePathFieldNumber = 1;

		// Token: 0x04004FB6 RID: 20406
		private string backgroundImagePath_ = "";
	}
}
