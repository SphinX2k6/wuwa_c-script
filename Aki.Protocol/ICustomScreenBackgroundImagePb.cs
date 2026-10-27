using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007BD RID: 1981
	public sealed class ICustomScreenBackgroundImagePb : IMessage<ICustomScreenBackgroundImagePb>, IMessage, IEquatable<ICustomScreenBackgroundImagePb>, IDeepCloneable<ICustomScreenBackgroundImagePb>, IBufferMessage
	{
		// Token: 0x0600B245 RID: 45637 RVA: 0x001AAF18 File Offset: 0x001A9118
		[NullableContext(1)]
		public static ICustomScreenBackgroundImagePb Create()
		{
			return new ICustomScreenBackgroundImagePb();
		}

		// Token: 0x170023F6 RID: 9206
		// (get) Token: 0x0600B246 RID: 45638 RVA: 0x001AAF1F File Offset: 0x001A911F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170023F7 RID: 9207
		// (get) Token: 0x0600B247 RID: 45639 RVA: 0x001AAF22 File Offset: 0x001A9122
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ICustomScreenBackgroundImagePb.Descriptor;
			}
		}

		// Token: 0x0600B248 RID: 45640 RVA: 0x001AAF29 File Offset: 0x001A9129
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ICustomScreenBackgroundImagePb()
		{
		}

		// Token: 0x0600B249 RID: 45641 RVA: 0x001AAF3C File Offset: 0x001A913C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ICustomScreenBackgroundImagePb(ICustomScreenBackgroundImagePb other) : this()
		{
			this.backgroundImagePath_ = other.backgroundImagePath_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B24A RID: 45642 RVA: 0x001AAF61 File Offset: 0x001A9161
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ICustomScreenBackgroundImagePb Clone()
		{
			return new ICustomScreenBackgroundImagePb(this);
		}

		// Token: 0x170023F8 RID: 9208
		// (get) Token: 0x0600B24B RID: 45643 RVA: 0x001AAF69 File Offset: 0x001A9169
		// (set) Token: 0x0600B24C RID: 45644 RVA: 0x001AAF71 File Offset: 0x001A9171
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

		// Token: 0x0600B24D RID: 45645 RVA: 0x001AAF84 File Offset: 0x001A9184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ICustomScreenBackgroundImagePb);
		}

		// Token: 0x0600B24E RID: 45646 RVA: 0x001AAF92 File Offset: 0x001A9192
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ICustomScreenBackgroundImagePb other)
		{
			return other != null && (other == this || (!(this.BackgroundImagePath != other.BackgroundImagePath) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B24F RID: 45647 RVA: 0x001AAFC8 File Offset: 0x001A91C8
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

		// Token: 0x0600B250 RID: 45648 RVA: 0x001AB009 File Offset: 0x001A9209
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B251 RID: 45649 RVA: 0x001AB016 File Offset: 0x001A9216
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B252 RID: 45650 RVA: 0x001AB01F File Offset: 0x001A921F
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

		// Token: 0x0600B253 RID: 45651 RVA: 0x001AB058 File Offset: 0x001A9258
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

		// Token: 0x0600B254 RID: 45652 RVA: 0x001AB09B File Offset: 0x001A929B
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

		// Token: 0x0600B255 RID: 45653 RVA: 0x001AB0D1 File Offset: 0x001A92D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B256 RID: 45654 RVA: 0x001AB0DC File Offset: 0x001A92DC
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

		// Token: 0x04004FBB RID: 20411
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004FBC RID: 20412
		public const int BackgroundImagePathFieldNumber = 1;

		// Token: 0x04004FBD RID: 20413
		private string backgroundImagePath_ = "";
	}
}
