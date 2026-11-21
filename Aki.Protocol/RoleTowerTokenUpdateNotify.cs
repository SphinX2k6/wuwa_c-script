using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010FE RID: 4350
	[NetMessage(EMessageId.RoleTowerTokenUpdateNotify)]
	public sealed class RoleTowerTokenUpdateNotify : IMessage<RoleTowerTokenUpdateNotify>, IMessage, IEquatable<RoleTowerTokenUpdateNotify>, IDeepCloneable<RoleTowerTokenUpdateNotify>, IBufferMessage
	{
		// Token: 0x0601741A RID: 95258 RVA: 0x003628C5 File Offset: 0x00360AC5
		[NullableContext(1)]
		public static RoleTowerTokenUpdateNotify Create()
		{
			return new RoleTowerTokenUpdateNotify();
		}

		// Token: 0x17004E24 RID: 20004
		// (get) Token: 0x0601741B RID: 95259 RVA: 0x003628CC File Offset: 0x00360ACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004E25 RID: 20005
		// (get) Token: 0x0601741C RID: 95260 RVA: 0x003628CF File Offset: 0x00360ACF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTowerTokenUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0601741D RID: 95261 RVA: 0x003628D6 File Offset: 0x00360AD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerTokenUpdateNotify()
		{
		}

		// Token: 0x0601741E RID: 95262 RVA: 0x003628DE File Offset: 0x00360ADE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerTokenUpdateNotify(RoleTowerTokenUpdateNotify other) : this()
		{
			this.tokenPanelInfo_ = ((other.tokenPanelInfo_ != null) ? other.tokenPanelInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601741F RID: 95263 RVA: 0x00362913 File Offset: 0x00360B13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerTokenUpdateNotify Clone()
		{
			return new RoleTowerTokenUpdateNotify(this);
		}

		// Token: 0x17004E26 RID: 20006
		// (get) Token: 0x06017420 RID: 95264 RVA: 0x0036291B File Offset: 0x00360B1B
		// (set) Token: 0x06017421 RID: 95265 RVA: 0x00362923 File Offset: 0x00360B23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerTokenPanelInfo TokenPanelInfo
		{
			get
			{
				return this.tokenPanelInfo_;
			}
			set
			{
				this.tokenPanelInfo_ = value;
			}
		}

		// Token: 0x06017422 RID: 95266 RVA: 0x0036292C File Offset: 0x00360B2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTowerTokenUpdateNotify);
		}

		// Token: 0x06017423 RID: 95267 RVA: 0x0036293A File Offset: 0x00360B3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTowerTokenUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.TokenPanelInfo, other.TokenPanelInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017424 RID: 95268 RVA: 0x00362970 File Offset: 0x00360B70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.tokenPanelInfo_ != null)
			{
				num ^= this.TokenPanelInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017425 RID: 95269 RVA: 0x003629AC File Offset: 0x00360BAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017426 RID: 95270 RVA: 0x003629B9 File Offset: 0x00360BB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017427 RID: 95271 RVA: 0x003629C2 File Offset: 0x00360BC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.tokenPanelInfo_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.TokenPanelInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017428 RID: 95272 RVA: 0x003629F4 File Offset: 0x00360BF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.tokenPanelInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TokenPanelInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017429 RID: 95273 RVA: 0x00362A34 File Offset: 0x00360C34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleTowerTokenUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.tokenPanelInfo_ != null)
			{
				if (this.tokenPanelInfo_ == null)
				{
					this.TokenPanelInfo = new RoleTowerTokenPanelInfo();
				}
				this.TokenPanelInfo.MergeFrom(other.TokenPanelInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601742A RID: 95274 RVA: 0x00362A88 File Offset: 0x00360C88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601742B RID: 95275 RVA: 0x00362A94 File Offset: 0x00360C94
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
				if (num != 26U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.tokenPanelInfo_ == null)
					{
						this.TokenPanelInfo = new RoleTowerTokenPanelInfo();
					}
					input.ReadMessage(this.TokenPanelInfo);
				}
			}
		}

		// Token: 0x04008B15 RID: 35605
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008B16 RID: 35606
		public const int TokenPanelInfoFieldNumber = 3;

		// Token: 0x04008B17 RID: 35607
		private RoleTowerTokenPanelInfo tokenPanelInfo_;
	}
}
