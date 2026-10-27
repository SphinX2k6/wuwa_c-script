using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D47 RID: 3399
	[NetMessage(EMessageId.PinballFriendRankRequest)]
	public sealed class PinballFriendRankRequest : IMessage<PinballFriendRankRequest>, IMessage, IEquatable<PinballFriendRankRequest>, IDeepCloneable<PinballFriendRankRequest>, IBufferMessage
	{
		// Token: 0x0601256D RID: 75117 RVA: 0x002AD1D5 File Offset: 0x002AB3D5
		[NullableContext(1)]
		public static PinballFriendRankRequest Create()
		{
			return new PinballFriendRankRequest();
		}

		// Token: 0x17003CC5 RID: 15557
		// (get) Token: 0x0601256E RID: 75118 RVA: 0x002AD1DC File Offset: 0x002AB3DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003CC6 RID: 15558
		// (get) Token: 0x0601256F RID: 75119 RVA: 0x002AD1DF File Offset: 0x002AB3DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballFriendRankRequest.Descriptor;
			}
		}

		// Token: 0x06012570 RID: 75120 RVA: 0x002AD1E6 File Offset: 0x002AB3E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballFriendRankRequest()
		{
		}

		// Token: 0x06012571 RID: 75121 RVA: 0x002AD1EE File Offset: 0x002AB3EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballFriendRankRequest(PinballFriendRankRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012572 RID: 75122 RVA: 0x002AD207 File Offset: 0x002AB407
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballFriendRankRequest Clone()
		{
			return new PinballFriendRankRequest(this);
		}

		// Token: 0x06012573 RID: 75123 RVA: 0x002AD20F File Offset: 0x002AB40F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballFriendRankRequest);
		}

		// Token: 0x06012574 RID: 75124 RVA: 0x002AD21D File Offset: 0x002AB41D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballFriendRankRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06012575 RID: 75125 RVA: 0x002AD23C File Offset: 0x002AB43C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012576 RID: 75126 RVA: 0x002AD262 File Offset: 0x002AB462
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012577 RID: 75127 RVA: 0x002AD26F File Offset: 0x002AB46F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012578 RID: 75128 RVA: 0x002AD278 File Offset: 0x002AB478
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012579 RID: 75129 RVA: 0x002AD290 File Offset: 0x002AB490
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601257A RID: 75130 RVA: 0x002AD2B6 File Offset: 0x002AB4B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PinballFriendRankRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601257B RID: 75131 RVA: 0x002AD2D3 File Offset: 0x002AB4D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601257C RID: 75132 RVA: 0x002AD2DC File Offset: 0x002AB4DC
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
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007248 RID: 29256
		private UnknownFieldSet _unknownFields;
	}
}
