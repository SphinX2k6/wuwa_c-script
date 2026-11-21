using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000D2 RID: 210
	[NetMessage(EMessageId.AdviceSettingNotify)]
	public sealed class AdviceSettingNotify : IMessage<AdviceSettingNotify>, IMessage, IEquatable<AdviceSettingNotify>, IDeepCloneable<AdviceSettingNotify>, IBufferMessage
	{
		// Token: 0x0600205B RID: 8283 RVA: 0x000578DF File Offset: 0x00055ADF
		[NullableContext(1)]
		public static AdviceSettingNotify Create()
		{
			return new AdviceSettingNotify();
		}

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x0600205C RID: 8284 RVA: 0x000578E6 File Offset: 0x00055AE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x0600205D RID: 8285 RVA: 0x000578E9 File Offset: 0x00055AE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AdviceSettingNotify.Descriptor;
			}
		}

		// Token: 0x0600205E RID: 8286 RVA: 0x000578F0 File Offset: 0x00055AF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceSettingNotify()
		{
		}

		// Token: 0x0600205F RID: 8287 RVA: 0x000578F8 File Offset: 0x00055AF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceSettingNotify(AdviceSettingNotify other) : this()
		{
			this.isShow_ = other.isShow_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002060 RID: 8288 RVA: 0x0005791D File Offset: 0x00055B1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceSettingNotify Clone()
		{
			return new AdviceSettingNotify(this);
		}

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x06002061 RID: 8289 RVA: 0x00057925 File Offset: 0x00055B25
		// (set) Token: 0x06002062 RID: 8290 RVA: 0x0005792D File Offset: 0x00055B2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsShow
		{
			get
			{
				return this.isShow_;
			}
			set
			{
				this.isShow_ = value;
			}
		}

		// Token: 0x06002063 RID: 8291 RVA: 0x00057936 File Offset: 0x00055B36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AdviceSettingNotify);
		}

		// Token: 0x06002064 RID: 8292 RVA: 0x00057944 File Offset: 0x00055B44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AdviceSettingNotify other)
		{
			return other != null && (other == this || (this.IsShow == other.IsShow && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002065 RID: 8293 RVA: 0x00057974 File Offset: 0x00055B74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsShow)
			{
				num ^= this.IsShow.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002066 RID: 8294 RVA: 0x000579B3 File Offset: 0x00055BB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002067 RID: 8295 RVA: 0x000579C0 File Offset: 0x00055BC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002068 RID: 8296 RVA: 0x000579C9 File Offset: 0x00055BC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsShow)
			{
				output.WriteRawTag(104);
				output.WriteBool(this.IsShow);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002069 RID: 8297 RVA: 0x000579FC File Offset: 0x00055BFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsShow)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600206A RID: 8298 RVA: 0x00057A2E File Offset: 0x00055C2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AdviceSettingNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsShow)
			{
				this.IsShow = other.IsShow;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600206B RID: 8299 RVA: 0x00057A5F File Offset: 0x00055C5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600206C RID: 8300 RVA: 0x00057A68 File Offset: 0x00055C68
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.IsShow = input.ReadBool();
				}
			}
		}

		// Token: 0x04002444 RID: 9284
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002445 RID: 9285
		public const int IsShowFieldNumber = 13;

		// Token: 0x04002446 RID: 9286
		private bool isShow_;
	}
}
