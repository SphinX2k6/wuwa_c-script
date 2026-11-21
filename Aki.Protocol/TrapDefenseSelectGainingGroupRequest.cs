using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014B7 RID: 5303
	[NetMessage(EMessageId.TrapDefenseSelectGainingGroupRequest)]
	public sealed class TrapDefenseSelectGainingGroupRequest : IMessage<TrapDefenseSelectGainingGroupRequest>, IMessage, IEquatable<TrapDefenseSelectGainingGroupRequest>, IDeepCloneable<TrapDefenseSelectGainingGroupRequest>, IBufferMessage
	{
		// Token: 0x0601C233 RID: 115251 RVA: 0x00415AAD File Offset: 0x00413CAD
		[NullableContext(1)]
		public static TrapDefenseSelectGainingGroupRequest Create()
		{
			return new TrapDefenseSelectGainingGroupRequest();
		}

		// Token: 0x17005F3D RID: 24381
		// (get) Token: 0x0601C234 RID: 115252 RVA: 0x00415AB4 File Offset: 0x00413CB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005F3E RID: 24382
		// (get) Token: 0x0601C235 RID: 115253 RVA: 0x00415AB7 File Offset: 0x00413CB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseSelectGainingGroupRequest.Descriptor;
			}
		}

		// Token: 0x0601C236 RID: 115254 RVA: 0x00415ABE File Offset: 0x00413CBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseSelectGainingGroupRequest()
		{
		}

		// Token: 0x0601C237 RID: 115255 RVA: 0x00415AC6 File Offset: 0x00413CC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseSelectGainingGroupRequest(TrapDefenseSelectGainingGroupRequest other) : this()
		{
			this.gainingGroupId_ = other.gainingGroupId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C238 RID: 115256 RVA: 0x00415AEB File Offset: 0x00413CEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseSelectGainingGroupRequest Clone()
		{
			return new TrapDefenseSelectGainingGroupRequest(this);
		}

		// Token: 0x17005F3F RID: 24383
		// (get) Token: 0x0601C239 RID: 115257 RVA: 0x00415AF3 File Offset: 0x00413CF3
		// (set) Token: 0x0601C23A RID: 115258 RVA: 0x00415AFB File Offset: 0x00413CFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GainingGroupId
		{
			get
			{
				return this.gainingGroupId_;
			}
			set
			{
				this.gainingGroupId_ = value;
			}
		}

		// Token: 0x0601C23B RID: 115259 RVA: 0x00415B04 File Offset: 0x00413D04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseSelectGainingGroupRequest);
		}

		// Token: 0x0601C23C RID: 115260 RVA: 0x00415B12 File Offset: 0x00413D12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseSelectGainingGroupRequest other)
		{
			return other != null && (other == this || (this.GainingGroupId == other.GainingGroupId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C23D RID: 115261 RVA: 0x00415B40 File Offset: 0x00413D40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GainingGroupId != 0)
			{
				num ^= this.GainingGroupId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C23E RID: 115262 RVA: 0x00415B7F File Offset: 0x00413D7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C23F RID: 115263 RVA: 0x00415B8C File Offset: 0x00413D8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C240 RID: 115264 RVA: 0x00415B95 File Offset: 0x00413D95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GainingGroupId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.GainingGroupId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C241 RID: 115265 RVA: 0x00415BC8 File Offset: 0x00413DC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GainingGroupId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GainingGroupId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C242 RID: 115266 RVA: 0x00415C06 File Offset: 0x00413E06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseSelectGainingGroupRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GainingGroupId != 0)
			{
				this.GainingGroupId = other.GainingGroupId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C243 RID: 115267 RVA: 0x00415C37 File Offset: 0x00413E37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C244 RID: 115268 RVA: 0x00415C40 File Offset: 0x00413E40
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
					this.GainingGroupId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A2D1 RID: 41681
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A2D2 RID: 41682
		public const int GainingGroupIdFieldNumber = 10;

		// Token: 0x0400A2D3 RID: 41683
		private int gainingGroupId_;
	}
}
