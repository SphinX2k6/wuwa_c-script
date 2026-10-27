using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011A4 RID: 4516
	public sealed class SeamlessTeleportArgs : IMessage<SeamlessTeleportArgs>, IMessage, IEquatable<SeamlessTeleportArgs>, IDeepCloneable<SeamlessTeleportArgs>, IBufferMessage
	{
		// Token: 0x06018102 RID: 98562 RVA: 0x0037E7AE File Offset: 0x0037C9AE
		[NullableContext(1)]
		public static SeamlessTeleportArgs Create()
		{
			return new SeamlessTeleportArgs();
		}

		// Token: 0x170050DF RID: 20703
		// (get) Token: 0x06018103 RID: 98563 RVA: 0x0037E7B5 File Offset: 0x0037C9B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170050E0 RID: 20704
		// (get) Token: 0x06018104 RID: 98564 RVA: 0x0037E7B8 File Offset: 0x0037C9B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SeamlessTeleportArgs.Descriptor;
			}
		}

		// Token: 0x06018105 RID: 98565 RVA: 0x0037E7BF File Offset: 0x0037C9BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SeamlessTeleportArgs()
		{
		}

		// Token: 0x06018106 RID: 98566 RVA: 0x0037E7C8 File Offset: 0x0037C9C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SeamlessTeleportArgs(SeamlessTeleportArgs other) : this()
		{
			switch (other.ArgsCase)
			{
			case SeamlessTeleportArgs.ArgsOneofCase.ClientTriggerTeleportPb:
				this.ClientTriggerTeleportPb = other.ClientTriggerTeleportPb.Clone();
				break;
			case SeamlessTeleportArgs.ArgsOneofCase.NoRenderPortalCtx:
				this.NoRenderPortalCtx = other.NoRenderPortalCtx.Clone();
				break;
			case SeamlessTeleportArgs.ArgsOneofCase.LongPressInteractTeleportPb:
				this.LongPressInteractTeleportPb = other.LongPressInteractTeleportPb.Clone();
				break;
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018107 RID: 98567 RVA: 0x0037E840 File Offset: 0x0037CA40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SeamlessTeleportArgs Clone()
		{
			return new SeamlessTeleportArgs(this);
		}

		// Token: 0x170050E1 RID: 20705
		// (get) Token: 0x06018108 RID: 98568 RVA: 0x0037E848 File Offset: 0x0037CA48
		// (set) Token: 0x06018109 RID: 98569 RVA: 0x0037E860 File Offset: 0x0037CA60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientTriggerTeleportPb ClientTriggerTeleportPb
		{
			get
			{
				if (this.argsCase_ != SeamlessTeleportArgs.ArgsOneofCase.ClientTriggerTeleportPb)
				{
					return null;
				}
				return (ClientTriggerTeleportPb)this.args_;
			}
			set
			{
				this.args_ = value;
				this.argsCase_ = ((value == null) ? SeamlessTeleportArgs.ArgsOneofCase.None : SeamlessTeleportArgs.ArgsOneofCase.ClientTriggerTeleportPb);
			}
		}

		// Token: 0x170050E2 RID: 20706
		// (get) Token: 0x0601810A RID: 98570 RVA: 0x0037E876 File Offset: 0x0037CA76
		// (set) Token: 0x0601810B RID: 98571 RVA: 0x0037E88E File Offset: 0x0037CA8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NoRenderPortalCtx NoRenderPortalCtx
		{
			get
			{
				if (this.argsCase_ != SeamlessTeleportArgs.ArgsOneofCase.NoRenderPortalCtx)
				{
					return null;
				}
				return (NoRenderPortalCtx)this.args_;
			}
			set
			{
				this.args_ = value;
				this.argsCase_ = ((value == null) ? SeamlessTeleportArgs.ArgsOneofCase.None : SeamlessTeleportArgs.ArgsOneofCase.NoRenderPortalCtx);
			}
		}

		// Token: 0x170050E3 RID: 20707
		// (get) Token: 0x0601810C RID: 98572 RVA: 0x0037E8A4 File Offset: 0x0037CAA4
		// (set) Token: 0x0601810D RID: 98573 RVA: 0x0037E8BC File Offset: 0x0037CABC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LongPressInteractTeleportPb LongPressInteractTeleportPb
		{
			get
			{
				if (this.argsCase_ != SeamlessTeleportArgs.ArgsOneofCase.LongPressInteractTeleportPb)
				{
					return null;
				}
				return (LongPressInteractTeleportPb)this.args_;
			}
			set
			{
				this.args_ = value;
				this.argsCase_ = ((value == null) ? SeamlessTeleportArgs.ArgsOneofCase.None : SeamlessTeleportArgs.ArgsOneofCase.LongPressInteractTeleportPb);
			}
		}

		// Token: 0x170050E4 RID: 20708
		// (get) Token: 0x0601810E RID: 98574 RVA: 0x0037E8D2 File Offset: 0x0037CAD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SeamlessTeleportArgs.ArgsOneofCase ArgsCase
		{
			get
			{
				return this.argsCase_;
			}
		}

		// Token: 0x0601810F RID: 98575 RVA: 0x0037E8DA File Offset: 0x0037CADA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearArgs()
		{
			this.argsCase_ = SeamlessTeleportArgs.ArgsOneofCase.None;
			this.args_ = null;
		}

		// Token: 0x06018110 RID: 98576 RVA: 0x0037E8EA File Offset: 0x0037CAEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SeamlessTeleportArgs);
		}

		// Token: 0x06018111 RID: 98577 RVA: 0x0037E8F8 File Offset: 0x0037CAF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SeamlessTeleportArgs other)
		{
			return other != null && (other == this || (object.Equals(this.ClientTriggerTeleportPb, other.ClientTriggerTeleportPb) && object.Equals(this.NoRenderPortalCtx, other.NoRenderPortalCtx) && object.Equals(this.LongPressInteractTeleportPb, other.LongPressInteractTeleportPb) && this.ArgsCase == other.ArgsCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018112 RID: 98578 RVA: 0x0037E970 File Offset: 0x0037CB70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.argsCase_ == SeamlessTeleportArgs.ArgsOneofCase.ClientTriggerTeleportPb)
			{
				num ^= this.ClientTriggerTeleportPb.GetHashCode();
			}
			if (this.argsCase_ == SeamlessTeleportArgs.ArgsOneofCase.NoRenderPortalCtx)
			{
				num ^= this.NoRenderPortalCtx.GetHashCode();
			}
			if (this.argsCase_ == SeamlessTeleportArgs.ArgsOneofCase.LongPressInteractTeleportPb)
			{
				num ^= this.LongPressInteractTeleportPb.GetHashCode();
			}
			num ^= (int)this.argsCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018113 RID: 98579 RVA: 0x0037E9E4 File Offset: 0x0037CBE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018114 RID: 98580 RVA: 0x0037E9F1 File Offset: 0x0037CBF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018115 RID: 98581 RVA: 0x0037E9FC File Offset: 0x0037CBFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.argsCase_ == SeamlessTeleportArgs.ArgsOneofCase.ClientTriggerTeleportPb)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.ClientTriggerTeleportPb);
			}
			if (this.argsCase_ == SeamlessTeleportArgs.ArgsOneofCase.NoRenderPortalCtx)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.NoRenderPortalCtx);
			}
			if (this.argsCase_ == SeamlessTeleportArgs.ArgsOneofCase.LongPressInteractTeleportPb)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.LongPressInteractTeleportPb);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018116 RID: 98582 RVA: 0x0037EA74 File Offset: 0x0037CC74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.argsCase_ == SeamlessTeleportArgs.ArgsOneofCase.ClientTriggerTeleportPb)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ClientTriggerTeleportPb);
			}
			if (this.argsCase_ == SeamlessTeleportArgs.ArgsOneofCase.NoRenderPortalCtx)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.NoRenderPortalCtx);
			}
			if (this.argsCase_ == SeamlessTeleportArgs.ArgsOneofCase.LongPressInteractTeleportPb)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.LongPressInteractTeleportPb);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018117 RID: 98583 RVA: 0x0037EAE8 File Offset: 0x0037CCE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SeamlessTeleportArgs other)
		{
			if (other == null)
			{
				return;
			}
			switch (other.ArgsCase)
			{
			case SeamlessTeleportArgs.ArgsOneofCase.ClientTriggerTeleportPb:
				if (this.ClientTriggerTeleportPb == null)
				{
					this.ClientTriggerTeleportPb = new ClientTriggerTeleportPb();
				}
				this.ClientTriggerTeleportPb.MergeFrom(other.ClientTriggerTeleportPb);
				break;
			case SeamlessTeleportArgs.ArgsOneofCase.NoRenderPortalCtx:
				if (this.NoRenderPortalCtx == null)
				{
					this.NoRenderPortalCtx = new NoRenderPortalCtx();
				}
				this.NoRenderPortalCtx.MergeFrom(other.NoRenderPortalCtx);
				break;
			case SeamlessTeleportArgs.ArgsOneofCase.LongPressInteractTeleportPb:
				if (this.LongPressInteractTeleportPb == null)
				{
					this.LongPressInteractTeleportPb = new LongPressInteractTeleportPb();
				}
				this.LongPressInteractTeleportPb.MergeFrom(other.LongPressInteractTeleportPb);
				break;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018118 RID: 98584 RVA: 0x0037EB9D File Offset: 0x0037CD9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018119 RID: 98585 RVA: 0x0037EBA8 File Offset: 0x0037CDA8
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
					if (num != 18U)
					{
						if (num != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							LongPressInteractTeleportPb longPressInteractTeleportPb = new LongPressInteractTeleportPb();
							if (this.argsCase_ == SeamlessTeleportArgs.ArgsOneofCase.LongPressInteractTeleportPb)
							{
								longPressInteractTeleportPb.MergeFrom(this.LongPressInteractTeleportPb);
							}
							input.ReadMessage(longPressInteractTeleportPb);
							this.LongPressInteractTeleportPb = longPressInteractTeleportPb;
						}
					}
					else
					{
						NoRenderPortalCtx noRenderPortalCtx = new NoRenderPortalCtx();
						if (this.argsCase_ == SeamlessTeleportArgs.ArgsOneofCase.NoRenderPortalCtx)
						{
							noRenderPortalCtx.MergeFrom(this.NoRenderPortalCtx);
						}
						input.ReadMessage(noRenderPortalCtx);
						this.NoRenderPortalCtx = noRenderPortalCtx;
					}
				}
				else
				{
					ClientTriggerTeleportPb clientTriggerTeleportPb = new ClientTriggerTeleportPb();
					if (this.argsCase_ == SeamlessTeleportArgs.ArgsOneofCase.ClientTriggerTeleportPb)
					{
						clientTriggerTeleportPb.MergeFrom(this.ClientTriggerTeleportPb);
					}
					input.ReadMessage(clientTriggerTeleportPb);
					this.ClientTriggerTeleportPb = clientTriggerTeleportPb;
				}
			}
		}

		// Token: 0x04008E74 RID: 36468
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008E75 RID: 36469
		public const int ClientTriggerTeleportPbFieldNumber = 1;

		// Token: 0x04008E76 RID: 36470
		public const int NoRenderPortalCtxFieldNumber = 2;

		// Token: 0x04008E77 RID: 36471
		public const int LongPressInteractTeleportPbFieldNumber = 3;

		// Token: 0x04008E78 RID: 36472
		private object args_;

		// Token: 0x04008E79 RID: 36473
		private SeamlessTeleportArgs.ArgsOneofCase argsCase_;

		// Token: 0x02001985 RID: 6533
		public enum ArgsOneofCase
		{
			// Token: 0x0400C9F7 RID: 51703
			None,
			// Token: 0x0400C9F8 RID: 51704
			ClientTriggerTeleportPb,
			// Token: 0x0400C9F9 RID: 51705
			NoRenderPortalCtx,
			// Token: 0x0400C9FA RID: 51706
			LongPressInteractTeleportPb
		}
	}
}
