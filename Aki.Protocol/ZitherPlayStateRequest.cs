using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001533 RID: 5427
	[NetMessage(EMessageId.ZitherPlayStateRequest)]
	public sealed class ZitherPlayStateRequest : IMessage<ZitherPlayStateRequest>, IMessage, IEquatable<ZitherPlayStateRequest>, IDeepCloneable<ZitherPlayStateRequest>, IBufferMessage
	{
		// Token: 0x0601CABE RID: 117438 RVA: 0x00423901 File Offset: 0x00421B01
		[NullableContext(1)]
		public static ZitherPlayStateRequest Create()
		{
			return new ZitherPlayStateRequest();
		}

		// Token: 0x170060A4 RID: 24740
		// (get) Token: 0x0601CABF RID: 117439 RVA: 0x00423908 File Offset: 0x00421B08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170060A5 RID: 24741
		// (get) Token: 0x0601CAC0 RID: 117440 RVA: 0x0042390B File Offset: 0x00421B0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ZitherPlayStateRequest.Descriptor;
			}
		}

		// Token: 0x0601CAC1 RID: 117441 RVA: 0x00423912 File Offset: 0x00421B12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ZitherPlayStateRequest()
		{
		}

		// Token: 0x0601CAC2 RID: 117442 RVA: 0x0042391A File Offset: 0x00421B1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ZitherPlayStateRequest(ZitherPlayStateRequest other) : this()
		{
			this.state_ = other.state_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CAC3 RID: 117443 RVA: 0x0042393F File Offset: 0x00421B3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ZitherPlayStateRequest Clone()
		{
			return new ZitherPlayStateRequest(this);
		}

		// Token: 0x170060A6 RID: 24742
		// (get) Token: 0x0601CAC4 RID: 117444 RVA: 0x00423947 File Offset: 0x00421B47
		// (set) Token: 0x0601CAC5 RID: 117445 RVA: 0x0042394F File Offset: 0x00421B4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ZitherOpState State
		{
			get
			{
				return this.state_;
			}
			set
			{
				this.state_ = value;
			}
		}

		// Token: 0x0601CAC6 RID: 117446 RVA: 0x00423958 File Offset: 0x00421B58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ZitherPlayStateRequest);
		}

		// Token: 0x0601CAC7 RID: 117447 RVA: 0x00423966 File Offset: 0x00421B66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ZitherPlayStateRequest other)
		{
			return other != null && (other == this || (this.State == other.State && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CAC8 RID: 117448 RVA: 0x00423994 File Offset: 0x00421B94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.State != ZitherOpState.OpEnter)
			{
				num ^= this.State.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601CAC9 RID: 117449 RVA: 0x004239D9 File Offset: 0x00421BD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CACA RID: 117450 RVA: 0x004239E6 File Offset: 0x00421BE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CACB RID: 117451 RVA: 0x004239EF File Offset: 0x00421BEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.State != ZitherOpState.OpEnter)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.State);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CACC RID: 117452 RVA: 0x00423A24 File Offset: 0x00421C24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.State != ZitherOpState.OpEnter)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.State);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601CACD RID: 117453 RVA: 0x00423A62 File Offset: 0x00421C62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ZitherPlayStateRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.State != ZitherOpState.OpEnter)
			{
				this.State = other.State;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601CACE RID: 117454 RVA: 0x00423A93 File Offset: 0x00421C93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CACF RID: 117455 RVA: 0x00423A9C File Offset: 0x00421C9C
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
					this.State = (ZitherOpState)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400A3D6 RID: 41942
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A3D7 RID: 41943
		public const int StateFieldNumber = 10;

		// Token: 0x0400A3D8 RID: 41944
		private ZitherOpState state_;
	}
}
