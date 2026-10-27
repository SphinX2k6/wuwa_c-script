using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012F8 RID: 4856
	[NetMessage(EMessageId.SwitchBattleModeResponse)]
	public sealed class SwitchBattleModeResponse : IMessage<SwitchBattleModeResponse>, IMessage, IEquatable<SwitchBattleModeResponse>, IDeepCloneable<SwitchBattleModeResponse>, IBufferMessage
	{
		// Token: 0x06019D0E RID: 105742 RVA: 0x003C0584 File Offset: 0x003BE784
		[NullableContext(1)]
		public static SwitchBattleModeResponse Create()
		{
			return new SwitchBattleModeResponse();
		}

		// Token: 0x1700570F RID: 22287
		// (get) Token: 0x06019D0F RID: 105743 RVA: 0x003C058B File Offset: 0x003BE78B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005710 RID: 22288
		// (get) Token: 0x06019D10 RID: 105744 RVA: 0x003C058E File Offset: 0x003BE78E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SwitchBattleModeResponse.Descriptor;
			}
		}

		// Token: 0x06019D11 RID: 105745 RVA: 0x003C0595 File Offset: 0x003BE795
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchBattleModeResponse()
		{
		}

		// Token: 0x06019D12 RID: 105746 RVA: 0x003C059D File Offset: 0x003BE79D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchBattleModeResponse(SwitchBattleModeResponse other) : this()
		{
			this.client_ = other.client_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019D13 RID: 105747 RVA: 0x003C05C2 File Offset: 0x003BE7C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchBattleModeResponse Clone()
		{
			return new SwitchBattleModeResponse(this);
		}

		// Token: 0x17005711 RID: 22289
		// (get) Token: 0x06019D14 RID: 105748 RVA: 0x003C05CA File Offset: 0x003BE7CA
		// (set) Token: 0x06019D15 RID: 105749 RVA: 0x003C05D2 File Offset: 0x003BE7D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Client
		{
			get
			{
				return this.client_;
			}
			set
			{
				this.client_ = value;
			}
		}

		// Token: 0x06019D16 RID: 105750 RVA: 0x003C05DB File Offset: 0x003BE7DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SwitchBattleModeResponse);
		}

		// Token: 0x06019D17 RID: 105751 RVA: 0x003C05E9 File Offset: 0x003BE7E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SwitchBattleModeResponse other)
		{
			return other != null && (other == this || (this.Client == other.Client && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019D18 RID: 105752 RVA: 0x003C0618 File Offset: 0x003BE818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Client)
			{
				num ^= this.Client.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019D19 RID: 105753 RVA: 0x003C0657 File Offset: 0x003BE857
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019D1A RID: 105754 RVA: 0x003C0664 File Offset: 0x003BE864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019D1B RID: 105755 RVA: 0x003C066D File Offset: 0x003BE86D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Client)
			{
				output.WriteRawTag(80);
				output.WriteBool(this.Client);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019D1C RID: 105756 RVA: 0x003C06A0 File Offset: 0x003BE8A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Client)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019D1D RID: 105757 RVA: 0x003C06D2 File Offset: 0x003BE8D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SwitchBattleModeResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Client)
			{
				this.Client = other.Client;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019D1E RID: 105758 RVA: 0x003C0703 File Offset: 0x003BE903
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019D1F RID: 105759 RVA: 0x003C070C File Offset: 0x003BE90C
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Client = input.ReadBool();
				}
			}
		}

		// Token: 0x04009709 RID: 38665
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400970A RID: 38666
		public const int ClientFieldNumber = 10;

		// Token: 0x0400970B RID: 38667
		private bool client_;
	}
}
