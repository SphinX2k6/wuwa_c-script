using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000130 RID: 304
	[NetMessage(EMessageId.AutoQuestNotify)]
	public sealed class AutoQuestNotify : IMessage<AutoQuestNotify>, IMessage, IEquatable<AutoQuestNotify>, IDeepCloneable<AutoQuestNotify>, IBufferMessage
	{
		// Token: 0x06002864 RID: 10340 RVA: 0x0006AA69 File Offset: 0x00068C69
		[NullableContext(1)]
		public static AutoQuestNotify Create()
		{
			return new AutoQuestNotify();
		}

		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x06002865 RID: 10341 RVA: 0x0006AA70 File Offset: 0x00068C70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x06002866 RID: 10342 RVA: 0x0006AA73 File Offset: 0x00068C73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AutoQuestNotify.Descriptor;
			}
		}

		// Token: 0x06002867 RID: 10343 RVA: 0x0006AA7A File Offset: 0x00068C7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AutoQuestNotify()
		{
		}

		// Token: 0x06002868 RID: 10344 RVA: 0x0006AA82 File Offset: 0x00068C82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AutoQuestNotify(AutoQuestNotify other) : this()
		{
			this.isAuto_ = other.isAuto_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002869 RID: 10345 RVA: 0x0006AAA7 File Offset: 0x00068CA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AutoQuestNotify Clone()
		{
			return new AutoQuestNotify(this);
		}

		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x0600286A RID: 10346 RVA: 0x0006AAAF File Offset: 0x00068CAF
		// (set) Token: 0x0600286B RID: 10347 RVA: 0x0006AAB7 File Offset: 0x00068CB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsAuto
		{
			get
			{
				return this.isAuto_;
			}
			set
			{
				this.isAuto_ = value;
			}
		}

		// Token: 0x0600286C RID: 10348 RVA: 0x0006AAC0 File Offset: 0x00068CC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AutoQuestNotify);
		}

		// Token: 0x0600286D RID: 10349 RVA: 0x0006AACE File Offset: 0x00068CCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AutoQuestNotify other)
		{
			return other != null && (other == this || (this.IsAuto == other.IsAuto && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600286E RID: 10350 RVA: 0x0006AAFC File Offset: 0x00068CFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsAuto)
			{
				num ^= this.IsAuto.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600286F RID: 10351 RVA: 0x0006AB3B File Offset: 0x00068D3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002870 RID: 10352 RVA: 0x0006AB48 File Offset: 0x00068D48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002871 RID: 10353 RVA: 0x0006AB51 File Offset: 0x00068D51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsAuto)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.IsAuto);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002872 RID: 10354 RVA: 0x0006AB84 File Offset: 0x00068D84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsAuto)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002873 RID: 10355 RVA: 0x0006ABB6 File Offset: 0x00068DB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AutoQuestNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsAuto)
			{
				this.IsAuto = other.IsAuto;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002874 RID: 10356 RVA: 0x0006ABE7 File Offset: 0x00068DE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002875 RID: 10357 RVA: 0x0006ABF0 File Offset: 0x00068DF0
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.IsAuto = input.ReadBool();
				}
			}
		}

		// Token: 0x040026F8 RID: 9976
		private UnknownFieldSet _unknownFields;

		// Token: 0x040026F9 RID: 9977
		public const int IsAutoFieldNumber = 6;

		// Token: 0x040026FA RID: 9978
		private bool isAuto_;
	}
}
