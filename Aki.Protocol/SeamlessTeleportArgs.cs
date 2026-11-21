using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011DE RID: 4574
	public sealed class SeamlessTeleportArgs : IMessage<SeamlessTeleportArgs>, IMessage, IEquatable<SeamlessTeleportArgs>, IDeepCloneable<SeamlessTeleportArgs>, IBufferMessage
	{
		// Token: 0x060186A3 RID: 100003 RVA: 0x0038DAF2 File Offset: 0x0038BCF2
		[NullableContext(1)]
		public static SeamlessTeleportArgs Create()
		{
			return new SeamlessTeleportArgs();
		}

		// Token: 0x1700524B RID: 21067
		// (get) Token: 0x060186A4 RID: 100004 RVA: 0x0038DAF9 File Offset: 0x0038BCF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700524C RID: 21068
		// (get) Token: 0x060186A5 RID: 100005 RVA: 0x0038DAFC File Offset: 0x0038BCFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SeamlessTeleportArgs.Descriptor;
			}
		}

		// Token: 0x060186A6 RID: 100006 RVA: 0x0038DB03 File Offset: 0x0038BD03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SeamlessTeleportArgs()
		{
		}

		// Token: 0x060186A7 RID: 100007 RVA: 0x0038DB0C File Offset: 0x0038BD0C
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

		// Token: 0x060186A8 RID: 100008 RVA: 0x0038DB84 File Offset: 0x0038BD84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SeamlessTeleportArgs Clone()
		{
			return new SeamlessTeleportArgs(this);
		}

		// Token: 0x1700524D RID: 21069
		// (get) Token: 0x060186A9 RID: 100009 RVA: 0x0038DB8C File Offset: 0x0038BD8C
		// (set) Token: 0x060186AA RID: 100010 RVA: 0x0038DBA4 File Offset: 0x0038BDA4
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

		// Token: 0x1700524E RID: 21070
		// (get) Token: 0x060186AB RID: 100011 RVA: 0x0038DBBA File Offset: 0x0038BDBA
		// (set) Token: 0x060186AC RID: 100012 RVA: 0x0038DBD2 File Offset: 0x0038BDD2
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

		// Token: 0x1700524F RID: 21071
		// (get) Token: 0x060186AD RID: 100013 RVA: 0x0038DBE8 File Offset: 0x0038BDE8
		// (set) Token: 0x060186AE RID: 100014 RVA: 0x0038DC00 File Offset: 0x0038BE00
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

		// Token: 0x17005250 RID: 21072
		// (get) Token: 0x060186AF RID: 100015 RVA: 0x0038DC16 File Offset: 0x0038BE16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SeamlessTeleportArgs.ArgsOneofCase ArgsCase
		{
			get
			{
				return this.argsCase_;
			}
		}

		// Token: 0x060186B0 RID: 100016 RVA: 0x0038DC1E File Offset: 0x0038BE1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearArgs()
		{
			this.argsCase_ = SeamlessTeleportArgs.ArgsOneofCase.None;
			this.args_ = null;
		}

		// Token: 0x060186B1 RID: 100017 RVA: 0x0038DC2E File Offset: 0x0038BE2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SeamlessTeleportArgs);
		}

		// Token: 0x060186B2 RID: 100018 RVA: 0x0038DC3C File Offset: 0x0038BE3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SeamlessTeleportArgs other)
		{
			return other != null && (other == this || (object.Equals(this.ClientTriggerTeleportPb, other.ClientTriggerTeleportPb) && object.Equals(this.NoRenderPortalCtx, other.NoRenderPortalCtx) && object.Equals(this.LongPressInteractTeleportPb, other.LongPressInteractTeleportPb) && this.ArgsCase == other.ArgsCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060186B3 RID: 100019 RVA: 0x0038DCB4 File Offset: 0x0038BEB4
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

		// Token: 0x060186B4 RID: 100020 RVA: 0x0038DD28 File Offset: 0x0038BF28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060186B5 RID: 100021 RVA: 0x0038DD35 File Offset: 0x0038BF35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060186B6 RID: 100022 RVA: 0x0038DD40 File Offset: 0x0038BF40
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

		// Token: 0x060186B7 RID: 100023 RVA: 0x0038DDB8 File Offset: 0x0038BFB8
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

		// Token: 0x060186B8 RID: 100024 RVA: 0x0038DE2C File Offset: 0x0038C02C
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

		// Token: 0x060186B9 RID: 100025 RVA: 0x0038DEE1 File Offset: 0x0038C0E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060186BA RID: 100026 RVA: 0x0038DEEC File Offset: 0x0038C0EC
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

		// Token: 0x04009107 RID: 37127
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009108 RID: 37128
		public const int ClientTriggerTeleportPbFieldNumber = 1;

		// Token: 0x04009109 RID: 37129
		public const int NoRenderPortalCtxFieldNumber = 2;

		// Token: 0x0400910A RID: 37130
		public const int LongPressInteractTeleportPbFieldNumber = 3;

		// Token: 0x0400910B RID: 37131
		private object args_;

		// Token: 0x0400910C RID: 37132
		private SeamlessTeleportArgs.ArgsOneofCase argsCase_;

		// Token: 0x02001A11 RID: 6673
		public enum ArgsOneofCase
		{
			// Token: 0x0400CF42 RID: 53058
			None,
			// Token: 0x0400CF43 RID: 53059
			ClientTriggerTeleportPb,
			// Token: 0x0400CF44 RID: 53060
			NoRenderPortalCtx,
			// Token: 0x0400CF45 RID: 53061
			LongPressInteractTeleportPb
		}
	}
}
