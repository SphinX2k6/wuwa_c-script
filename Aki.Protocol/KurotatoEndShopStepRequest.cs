using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000892 RID: 2194
	[NetMessage(EMessageId.KurotatoEndShopStepRequest)]
	public sealed class KurotatoEndShopStepRequest : IMessage<KurotatoEndShopStepRequest>, IMessage, IEquatable<KurotatoEndShopStepRequest>, IDeepCloneable<KurotatoEndShopStepRequest>, IBufferMessage
	{
		// Token: 0x0600C315 RID: 49941 RVA: 0x001CEFDD File Offset: 0x001CD1DD
		[NullableContext(1)]
		public static KurotatoEndShopStepRequest Create()
		{
			return new KurotatoEndShopStepRequest();
		}

		// Token: 0x1700276F RID: 10095
		// (get) Token: 0x0600C316 RID: 49942 RVA: 0x001CEFE4 File Offset: 0x001CD1E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002770 RID: 10096
		// (get) Token: 0x0600C317 RID: 49943 RVA: 0x001CEFE7 File Offset: 0x001CD1E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoEndShopStepRequest.Descriptor;
			}
		}

		// Token: 0x0600C318 RID: 49944 RVA: 0x001CEFEE File Offset: 0x001CD1EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoEndShopStepRequest()
		{
		}

		// Token: 0x0600C319 RID: 49945 RVA: 0x001CEFF6 File Offset: 0x001CD1F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoEndShopStepRequest(KurotatoEndShopStepRequest other) : this()
		{
			this.isEndLess_ = other.isEndLess_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C31A RID: 49946 RVA: 0x001CF01B File Offset: 0x001CD21B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoEndShopStepRequest Clone()
		{
			return new KurotatoEndShopStepRequest(this);
		}

		// Token: 0x17002771 RID: 10097
		// (get) Token: 0x0600C31B RID: 49947 RVA: 0x001CF023 File Offset: 0x001CD223
		// (set) Token: 0x0600C31C RID: 49948 RVA: 0x001CF02B File Offset: 0x001CD22B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsEndLess
		{
			get
			{
				return this.isEndLess_;
			}
			set
			{
				this.isEndLess_ = value;
			}
		}

		// Token: 0x0600C31D RID: 49949 RVA: 0x001CF034 File Offset: 0x001CD234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoEndShopStepRequest);
		}

		// Token: 0x0600C31E RID: 49950 RVA: 0x001CF042 File Offset: 0x001CD242
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoEndShopStepRequest other)
		{
			return other != null && (other == this || (this.IsEndLess == other.IsEndLess && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C31F RID: 49951 RVA: 0x001CF070 File Offset: 0x001CD270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsEndLess)
			{
				num ^= this.IsEndLess.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C320 RID: 49952 RVA: 0x001CF0AF File Offset: 0x001CD2AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C321 RID: 49953 RVA: 0x001CF0BC File Offset: 0x001CD2BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C322 RID: 49954 RVA: 0x001CF0C5 File Offset: 0x001CD2C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsEndLess)
			{
				output.WriteRawTag(112);
				output.WriteBool(this.IsEndLess);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C323 RID: 49955 RVA: 0x001CF0F8 File Offset: 0x001CD2F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsEndLess)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C324 RID: 49956 RVA: 0x001CF12A File Offset: 0x001CD32A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoEndShopStepRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsEndLess)
			{
				this.IsEndLess = other.IsEndLess;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C325 RID: 49957 RVA: 0x001CF15B File Offset: 0x001CD35B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C326 RID: 49958 RVA: 0x001CF164 File Offset: 0x001CD364
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.IsEndLess = input.ReadBool();
				}
			}
		}

		// Token: 0x0400545C RID: 21596
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400545D RID: 21597
		public const int IsEndLessFieldNumber = 14;

		// Token: 0x0400545E RID: 21598
		private bool isEndLess_;
	}
}
