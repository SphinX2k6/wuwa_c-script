using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000194 RID: 404
	[NetMessage(EMessageId.BeforeHitPush)]
	public sealed class BeforeHitPush : IMessage<BeforeHitPush>, IMessage, IEquatable<BeforeHitPush>, IDeepCloneable<BeforeHitPush>, IBufferMessage
	{
		// Token: 0x06003013 RID: 12307 RVA: 0x0007AE6C File Offset: 0x0007906C
		[NullableContext(1)]
		public static BeforeHitPush Create()
		{
			return new BeforeHitPush();
		}

		// Token: 0x17000767 RID: 1895
		// (get) Token: 0x06003014 RID: 12308 RVA: 0x0007AE73 File Offset: 0x00079073
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000768 RID: 1896
		// (get) Token: 0x06003015 RID: 12309 RVA: 0x0007AE76 File Offset: 0x00079076
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BeforeHitPush.Descriptor;
			}
		}

		// Token: 0x06003016 RID: 12310 RVA: 0x0007AE7D File Offset: 0x0007907D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeforeHitPush()
		{
		}

		// Token: 0x06003017 RID: 12311 RVA: 0x0007AE85 File Offset: 0x00079085
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeforeHitPush(BeforeHitPush other) : this()
		{
			this.beforeHitInformation_ = ((other.beforeHitInformation_ != null) ? other.beforeHitInformation_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003018 RID: 12312 RVA: 0x0007AEBA File Offset: 0x000790BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeforeHitPush Clone()
		{
			return new BeforeHitPush(this);
		}

		// Token: 0x17000769 RID: 1897
		// (get) Token: 0x06003019 RID: 12313 RVA: 0x0007AEC2 File Offset: 0x000790C2
		// (set) Token: 0x0600301A RID: 12314 RVA: 0x0007AECA File Offset: 0x000790CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeforeHitInformation BeforeHitInformation
		{
			get
			{
				return this.beforeHitInformation_;
			}
			set
			{
				this.beforeHitInformation_ = value;
			}
		}

		// Token: 0x0600301B RID: 12315 RVA: 0x0007AED3 File Offset: 0x000790D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BeforeHitPush);
		}

		// Token: 0x0600301C RID: 12316 RVA: 0x0007AEE1 File Offset: 0x000790E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BeforeHitPush other)
		{
			return other != null && (other == this || (object.Equals(this.BeforeHitInformation, other.BeforeHitInformation) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600301D RID: 12317 RVA: 0x0007AF14 File Offset: 0x00079114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.beforeHitInformation_ != null)
			{
				num ^= this.BeforeHitInformation.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600301E RID: 12318 RVA: 0x0007AF50 File Offset: 0x00079150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600301F RID: 12319 RVA: 0x0007AF5D File Offset: 0x0007915D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003020 RID: 12320 RVA: 0x0007AF66 File Offset: 0x00079166
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.beforeHitInformation_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.BeforeHitInformation);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003021 RID: 12321 RVA: 0x0007AF98 File Offset: 0x00079198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.beforeHitInformation_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BeforeHitInformation);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003022 RID: 12322 RVA: 0x0007AFD8 File Offset: 0x000791D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BeforeHitPush other)
		{
			if (other == null)
			{
				return;
			}
			if (other.beforeHitInformation_ != null)
			{
				if (this.beforeHitInformation_ == null)
				{
					this.BeforeHitInformation = new BeforeHitInformation();
				}
				this.BeforeHitInformation.MergeFrom(other.BeforeHitInformation);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003023 RID: 12323 RVA: 0x0007B02C File Offset: 0x0007922C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003024 RID: 12324 RVA: 0x0007B038 File Offset: 0x00079238
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
				if (num != 106U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.beforeHitInformation_ == null)
					{
						this.BeforeHitInformation = new BeforeHitInformation();
					}
					input.ReadMessage(this.BeforeHitInformation);
				}
			}
		}

		// Token: 0x040028DC RID: 10460
		private UnknownFieldSet _unknownFields;

		// Token: 0x040028DD RID: 10461
		public const int BeforeHitInformationFieldNumber = 13;

		// Token: 0x040028DE RID: 10462
		private BeforeHitInformation beforeHitInformation_;
	}
}
