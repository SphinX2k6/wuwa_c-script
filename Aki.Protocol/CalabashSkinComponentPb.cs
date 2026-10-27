using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000225 RID: 549
	public sealed class CalabashSkinComponentPb : IMessage<CalabashSkinComponentPb>, IMessage, IEquatable<CalabashSkinComponentPb>, IDeepCloneable<CalabashSkinComponentPb>, IBufferMessage
	{
		// Token: 0x06003BD5 RID: 15317 RVA: 0x00094D4B File Offset: 0x00092F4B
		[NullableContext(1)]
		public static CalabashSkinComponentPb Create()
		{
			return new CalabashSkinComponentPb();
		}

		// Token: 0x170009ED RID: 2541
		// (get) Token: 0x06003BD6 RID: 15318 RVA: 0x00094D52 File Offset: 0x00092F52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170009EE RID: 2542
		// (get) Token: 0x06003BD7 RID: 15319 RVA: 0x00094D55 File Offset: 0x00092F55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CalabashSkinComponentPb.Descriptor;
			}
		}

		// Token: 0x06003BD8 RID: 15320 RVA: 0x00094D5C File Offset: 0x00092F5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashSkinComponentPb()
		{
		}

		// Token: 0x06003BD9 RID: 15321 RVA: 0x00094D64 File Offset: 0x00092F64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashSkinComponentPb(CalabashSkinComponentPb other) : this()
		{
			this.calabashSkinId_ = other.calabashSkinId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003BDA RID: 15322 RVA: 0x00094D89 File Offset: 0x00092F89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashSkinComponentPb Clone()
		{
			return new CalabashSkinComponentPb(this);
		}

		// Token: 0x170009EF RID: 2543
		// (get) Token: 0x06003BDB RID: 15323 RVA: 0x00094D91 File Offset: 0x00092F91
		// (set) Token: 0x06003BDC RID: 15324 RVA: 0x00094D99 File Offset: 0x00092F99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalabashSkinId
		{
			get
			{
				return this.calabashSkinId_;
			}
			set
			{
				this.calabashSkinId_ = value;
			}
		}

		// Token: 0x06003BDD RID: 15325 RVA: 0x00094DA2 File Offset: 0x00092FA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CalabashSkinComponentPb);
		}

		// Token: 0x06003BDE RID: 15326 RVA: 0x00094DB0 File Offset: 0x00092FB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CalabashSkinComponentPb other)
		{
			return other != null && (other == this || (this.CalabashSkinId == other.CalabashSkinId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003BDF RID: 15327 RVA: 0x00094DE0 File Offset: 0x00092FE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CalabashSkinId != 0)
			{
				num ^= this.CalabashSkinId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003BE0 RID: 15328 RVA: 0x00094E1F File Offset: 0x0009301F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003BE1 RID: 15329 RVA: 0x00094E2C File Offset: 0x0009302C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003BE2 RID: 15330 RVA: 0x00094E35 File Offset: 0x00093035
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CalabashSkinId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.CalabashSkinId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003BE3 RID: 15331 RVA: 0x00094E68 File Offset: 0x00093068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CalabashSkinId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CalabashSkinId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003BE4 RID: 15332 RVA: 0x00094EA6 File Offset: 0x000930A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CalabashSkinComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CalabashSkinId != 0)
			{
				this.CalabashSkinId = other.CalabashSkinId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003BE5 RID: 15333 RVA: 0x00094ED7 File Offset: 0x000930D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003BE6 RID: 15334 RVA: 0x00094EE0 File Offset: 0x000930E0
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.CalabashSkinId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002C45 RID: 11333
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002C46 RID: 11334
		public const int CalabashSkinIdFieldNumber = 1;

		// Token: 0x04002C47 RID: 11335
		private int calabashSkinId_;
	}
}
