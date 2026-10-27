using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D9E RID: 3486
	[NetMessage(EMessageId.PlayerNetStatePush)]
	public sealed class PlayerNetStatePush : IMessage<PlayerNetStatePush>, IMessage, IEquatable<PlayerNetStatePush>, IDeepCloneable<PlayerNetStatePush>, IBufferMessage
	{
		// Token: 0x06012CA0 RID: 76960 RVA: 0x002BDC1C File Offset: 0x002BBE1C
		[NullableContext(1)]
		public static PlayerNetStatePush Create()
		{
			return new PlayerNetStatePush();
		}

		// Token: 0x17003E59 RID: 15961
		// (get) Token: 0x06012CA1 RID: 76961 RVA: 0x002BDC23 File Offset: 0x002BBE23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003E5A RID: 15962
		// (get) Token: 0x06012CA2 RID: 76962 RVA: 0x002BDC26 File Offset: 0x002BBE26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerNetStatePush.Descriptor;
			}
		}

		// Token: 0x06012CA3 RID: 76963 RVA: 0x002BDC2D File Offset: 0x002BBE2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerNetStatePush()
		{
		}

		// Token: 0x06012CA4 RID: 76964 RVA: 0x002BDC35 File Offset: 0x002BBE35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerNetStatePush(PlayerNetStatePush other) : this()
		{
			this.rttMs_ = other.rttMs_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012CA5 RID: 76965 RVA: 0x002BDC5A File Offset: 0x002BBE5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerNetStatePush Clone()
		{
			return new PlayerNetStatePush(this);
		}

		// Token: 0x17003E5B RID: 15963
		// (get) Token: 0x06012CA6 RID: 76966 RVA: 0x002BDC62 File Offset: 0x002BBE62
		// (set) Token: 0x06012CA7 RID: 76967 RVA: 0x002BDC6A File Offset: 0x002BBE6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RttMs
		{
			get
			{
				return this.rttMs_;
			}
			set
			{
				this.rttMs_ = value;
			}
		}

		// Token: 0x06012CA8 RID: 76968 RVA: 0x002BDC73 File Offset: 0x002BBE73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerNetStatePush);
		}

		// Token: 0x06012CA9 RID: 76969 RVA: 0x002BDC81 File Offset: 0x002BBE81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerNetStatePush other)
		{
			return other != null && (other == this || (this.RttMs == other.RttMs && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012CAA RID: 76970 RVA: 0x002BDCB0 File Offset: 0x002BBEB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RttMs != 0)
			{
				num ^= this.RttMs.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012CAB RID: 76971 RVA: 0x002BDCEF File Offset: 0x002BBEEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012CAC RID: 76972 RVA: 0x002BDCFC File Offset: 0x002BBEFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012CAD RID: 76973 RVA: 0x002BDD05 File Offset: 0x002BBF05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RttMs != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.RttMs);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012CAE RID: 76974 RVA: 0x002BDD38 File Offset: 0x002BBF38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RttMs != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RttMs);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012CAF RID: 76975 RVA: 0x002BDD76 File Offset: 0x002BBF76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerNetStatePush other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RttMs != 0)
			{
				this.RttMs = other.RttMs;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012CB0 RID: 76976 RVA: 0x002BDDA7 File Offset: 0x002BBFA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012CB1 RID: 76977 RVA: 0x002BDDB0 File Offset: 0x002BBFB0
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.RttMs = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007468 RID: 29800
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007469 RID: 29801
		public const int RttMsFieldNumber = 3;

		// Token: 0x0400746A RID: 29802
		private int rttMs_;
	}
}
