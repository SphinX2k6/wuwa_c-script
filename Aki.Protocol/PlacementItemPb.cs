using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D76 RID: 3446
	public sealed class PlacementItemPb : IMessage<PlacementItemPb>, IMessage, IEquatable<PlacementItemPb>, IDeepCloneable<PlacementItemPb>, IBufferMessage
	{
		// Token: 0x0601293A RID: 76090 RVA: 0x002B5AA9 File Offset: 0x002B3CA9
		[NullableContext(1)]
		public static PlacementItemPb Create()
		{
			return new PlacementItemPb();
		}

		// Token: 0x17003D94 RID: 15764
		// (get) Token: 0x0601293B RID: 76091 RVA: 0x002B5AB0 File Offset: 0x002B3CB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003D95 RID: 15765
		// (get) Token: 0x0601293C RID: 76092 RVA: 0x002B5AB3 File Offset: 0x002B3CB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlacementItemPb.Descriptor;
			}
		}

		// Token: 0x0601293D RID: 76093 RVA: 0x002B5ABA File Offset: 0x002B3CBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlacementItemPb()
		{
		}

		// Token: 0x0601293E RID: 76094 RVA: 0x002B5AC2 File Offset: 0x002B3CC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlacementItemPb(PlacementItemPb other) : this()
		{
			this.locatedBoardEntityConfigId_ = other.locatedBoardEntityConfigId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601293F RID: 76095 RVA: 0x002B5AE7 File Offset: 0x002B3CE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlacementItemPb Clone()
		{
			return new PlacementItemPb(this);
		}

		// Token: 0x17003D96 RID: 15766
		// (get) Token: 0x06012940 RID: 76096 RVA: 0x002B5AEF File Offset: 0x002B3CEF
		// (set) Token: 0x06012941 RID: 76097 RVA: 0x002B5AF7 File Offset: 0x002B3CF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LocatedBoardEntityConfigId
		{
			get
			{
				return this.locatedBoardEntityConfigId_;
			}
			set
			{
				this.locatedBoardEntityConfigId_ = value;
			}
		}

		// Token: 0x06012942 RID: 76098 RVA: 0x002B5B00 File Offset: 0x002B3D00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlacementItemPb);
		}

		// Token: 0x06012943 RID: 76099 RVA: 0x002B5B0E File Offset: 0x002B3D0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlacementItemPb other)
		{
			return other != null && (other == this || (this.LocatedBoardEntityConfigId == other.LocatedBoardEntityConfigId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012944 RID: 76100 RVA: 0x002B5B3C File Offset: 0x002B3D3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LocatedBoardEntityConfigId != 0)
			{
				num ^= this.LocatedBoardEntityConfigId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012945 RID: 76101 RVA: 0x002B5B7B File Offset: 0x002B3D7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012946 RID: 76102 RVA: 0x002B5B88 File Offset: 0x002B3D88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012947 RID: 76103 RVA: 0x002B5B91 File Offset: 0x002B3D91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LocatedBoardEntityConfigId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.LocatedBoardEntityConfigId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012948 RID: 76104 RVA: 0x002B5BC4 File Offset: 0x002B3DC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LocatedBoardEntityConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LocatedBoardEntityConfigId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012949 RID: 76105 RVA: 0x002B5C02 File Offset: 0x002B3E02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlacementItemPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LocatedBoardEntityConfigId != 0)
			{
				this.LocatedBoardEntityConfigId = other.LocatedBoardEntityConfigId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601294A RID: 76106 RVA: 0x002B5C33 File Offset: 0x002B3E33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601294B RID: 76107 RVA: 0x002B5C3C File Offset: 0x002B3E3C
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.LocatedBoardEntityConfigId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007356 RID: 29526
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007357 RID: 29527
		public const int LocatedBoardEntityConfigIdFieldNumber = 1;

		// Token: 0x04007358 RID: 29528
		private int locatedBoardEntityConfigId_;
	}
}
