using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001486 RID: 5254
	[NetMessage(EMessageId.TrapDefenseBuildingResetRequest)]
	public sealed class TrapDefenseBuildingResetRequest : IMessage<TrapDefenseBuildingResetRequest>, IMessage, IEquatable<TrapDefenseBuildingResetRequest>, IDeepCloneable<TrapDefenseBuildingResetRequest>, IBufferMessage
	{
		// Token: 0x0601BE62 RID: 114274 RVA: 0x0040DB5C File Offset: 0x0040BD5C
		[NullableContext(1)]
		public static TrapDefenseBuildingResetRequest Create()
		{
			return new TrapDefenseBuildingResetRequest();
		}

		// Token: 0x17005E76 RID: 24182
		// (get) Token: 0x0601BE63 RID: 114275 RVA: 0x0040DB63 File Offset: 0x0040BD63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005E77 RID: 24183
		// (get) Token: 0x0601BE64 RID: 114276 RVA: 0x0040DB66 File Offset: 0x0040BD66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseBuildingResetRequest.Descriptor;
			}
		}

		// Token: 0x0601BE65 RID: 114277 RVA: 0x0040DB6D File Offset: 0x0040BD6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseBuildingResetRequest()
		{
		}

		// Token: 0x0601BE66 RID: 114278 RVA: 0x0040DB75 File Offset: 0x0040BD75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseBuildingResetRequest(TrapDefenseBuildingResetRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BE67 RID: 114279 RVA: 0x0040DB9A File Offset: 0x0040BD9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseBuildingResetRequest Clone()
		{
			return new TrapDefenseBuildingResetRequest(this);
		}

		// Token: 0x17005E78 RID: 24184
		// (get) Token: 0x0601BE68 RID: 114280 RVA: 0x0040DBA2 File Offset: 0x0040BDA2
		// (set) Token: 0x0601BE69 RID: 114281 RVA: 0x0040DBAA File Offset: 0x0040BDAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x0601BE6A RID: 114282 RVA: 0x0040DBB3 File Offset: 0x0040BDB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseBuildingResetRequest);
		}

		// Token: 0x0601BE6B RID: 114283 RVA: 0x0040DBC1 File Offset: 0x0040BDC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseBuildingResetRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BE6C RID: 114284 RVA: 0x0040DBF0 File Offset: 0x0040BDF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601BE6D RID: 114285 RVA: 0x0040DC2F File Offset: 0x0040BE2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BE6E RID: 114286 RVA: 0x0040DC3C File Offset: 0x0040BE3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BE6F RID: 114287 RVA: 0x0040DC45 File Offset: 0x0040BE45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BE70 RID: 114288 RVA: 0x0040DC78 File Offset: 0x0040BE78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601BE71 RID: 114289 RVA: 0x0040DCB6 File Offset: 0x0040BEB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseBuildingResetRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BE72 RID: 114290 RVA: 0x0040DCE7 File Offset: 0x0040BEE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BE73 RID: 114291 RVA: 0x0040DCF0 File Offset: 0x0040BEF0
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A1D4 RID: 41428
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A1D5 RID: 41429
		public const int IdFieldNumber = 6;

		// Token: 0x0400A1D6 RID: 41430
		private int id_;
	}
}
