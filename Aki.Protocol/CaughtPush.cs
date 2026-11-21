using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000242 RID: 578
	[NetMessage(EMessageId.CaughtPush)]
	public sealed class CaughtPush : IMessage<CaughtPush>, IMessage, IEquatable<CaughtPush>, IDeepCloneable<CaughtPush>, IBufferMessage
	{
		// Token: 0x06003E58 RID: 15960 RVA: 0x0009A79C File Offset: 0x0009899C
		[NullableContext(1)]
		public static CaughtPush Create()
		{
			return new CaughtPush();
		}

		// Token: 0x17000A6B RID: 2667
		// (get) Token: 0x06003E59 RID: 15961 RVA: 0x0009A7A3 File Offset: 0x000989A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000A6C RID: 2668
		// (get) Token: 0x06003E5A RID: 15962 RVA: 0x0009A7A6 File Offset: 0x000989A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CaughtPush.Descriptor;
			}
		}

		// Token: 0x06003E5B RID: 15963 RVA: 0x0009A7AD File Offset: 0x000989AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CaughtPush()
		{
		}

		// Token: 0x06003E5C RID: 15964 RVA: 0x0009A7B5 File Offset: 0x000989B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CaughtPush(CaughtPush other) : this()
		{
			this.info_ = ((other.info_ != null) ? other.info_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003E5D RID: 15965 RVA: 0x0009A7EA File Offset: 0x000989EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CaughtPush Clone()
		{
			return new CaughtPush(this);
		}

		// Token: 0x17000A6D RID: 2669
		// (get) Token: 0x06003E5E RID: 15966 RVA: 0x0009A7F2 File Offset: 0x000989F2
		// (set) Token: 0x06003E5F RID: 15967 RVA: 0x0009A7FA File Offset: 0x000989FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CaughtInfo Info
		{
			get
			{
				return this.info_;
			}
			set
			{
				this.info_ = value;
			}
		}

		// Token: 0x06003E60 RID: 15968 RVA: 0x0009A803 File Offset: 0x00098A03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CaughtPush);
		}

		// Token: 0x06003E61 RID: 15969 RVA: 0x0009A811 File Offset: 0x00098A11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CaughtPush other)
		{
			return other != null && (other == this || (object.Equals(this.Info, other.Info) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003E62 RID: 15970 RVA: 0x0009A844 File Offset: 0x00098A44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.info_ != null)
			{
				num ^= this.Info.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003E63 RID: 15971 RVA: 0x0009A880 File Offset: 0x00098A80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003E64 RID: 15972 RVA: 0x0009A88D File Offset: 0x00098A8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003E65 RID: 15973 RVA: 0x0009A896 File Offset: 0x00098A96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.info_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.Info);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003E66 RID: 15974 RVA: 0x0009A8C8 File Offset: 0x00098AC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.info_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Info);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003E67 RID: 15975 RVA: 0x0009A908 File Offset: 0x00098B08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CaughtPush other)
		{
			if (other == null)
			{
				return;
			}
			if (other.info_ != null)
			{
				if (this.info_ == null)
				{
					this.Info = new CaughtInfo();
				}
				this.Info.MergeFrom(other.Info);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003E68 RID: 15976 RVA: 0x0009A95C File Offset: 0x00098B5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003E69 RID: 15977 RVA: 0x0009A968 File Offset: 0x00098B68
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
				if (num != 122U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.info_ == null)
					{
						this.Info = new CaughtInfo();
					}
					input.ReadMessage(this.Info);
				}
			}
		}

		// Token: 0x04002D3F RID: 11583
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D40 RID: 11584
		public const int InfoFieldNumber = 15;

		// Token: 0x04002D41 RID: 11585
		private CaughtInfo info_;
	}
}
