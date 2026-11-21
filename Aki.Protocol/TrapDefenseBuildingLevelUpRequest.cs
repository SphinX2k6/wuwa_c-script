using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001483 RID: 5251
	[NetMessage(EMessageId.TrapDefenseBuildingLevelUpRequest)]
	public sealed class TrapDefenseBuildingLevelUpRequest : IMessage<TrapDefenseBuildingLevelUpRequest>, IMessage, IEquatable<TrapDefenseBuildingLevelUpRequest>, IDeepCloneable<TrapDefenseBuildingLevelUpRequest>, IBufferMessage
	{
		// Token: 0x0601BE26 RID: 114214 RVA: 0x0040D3AC File Offset: 0x0040B5AC
		[NullableContext(1)]
		public static TrapDefenseBuildingLevelUpRequest Create()
		{
			return new TrapDefenseBuildingLevelUpRequest();
		}

		// Token: 0x17005E6A RID: 24170
		// (get) Token: 0x0601BE27 RID: 114215 RVA: 0x0040D3B3 File Offset: 0x0040B5B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005E6B RID: 24171
		// (get) Token: 0x0601BE28 RID: 114216 RVA: 0x0040D3B6 File Offset: 0x0040B5B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseBuildingLevelUpRequest.Descriptor;
			}
		}

		// Token: 0x0601BE29 RID: 114217 RVA: 0x0040D3BD File Offset: 0x0040B5BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseBuildingLevelUpRequest()
		{
		}

		// Token: 0x0601BE2A RID: 114218 RVA: 0x0040D3C5 File Offset: 0x0040B5C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseBuildingLevelUpRequest(TrapDefenseBuildingLevelUpRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BE2B RID: 114219 RVA: 0x0040D3EA File Offset: 0x0040B5EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseBuildingLevelUpRequest Clone()
		{
			return new TrapDefenseBuildingLevelUpRequest(this);
		}

		// Token: 0x17005E6C RID: 24172
		// (get) Token: 0x0601BE2C RID: 114220 RVA: 0x0040D3F2 File Offset: 0x0040B5F2
		// (set) Token: 0x0601BE2D RID: 114221 RVA: 0x0040D3FA File Offset: 0x0040B5FA
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

		// Token: 0x0601BE2E RID: 114222 RVA: 0x0040D403 File Offset: 0x0040B603
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseBuildingLevelUpRequest);
		}

		// Token: 0x0601BE2F RID: 114223 RVA: 0x0040D411 File Offset: 0x0040B611
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseBuildingLevelUpRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BE30 RID: 114224 RVA: 0x0040D440 File Offset: 0x0040B640
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

		// Token: 0x0601BE31 RID: 114225 RVA: 0x0040D47F File Offset: 0x0040B67F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BE32 RID: 114226 RVA: 0x0040D48C File Offset: 0x0040B68C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BE33 RID: 114227 RVA: 0x0040D495 File Offset: 0x0040B695
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

		// Token: 0x0601BE34 RID: 114228 RVA: 0x0040D4C8 File Offset: 0x0040B6C8
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

		// Token: 0x0601BE35 RID: 114229 RVA: 0x0040D506 File Offset: 0x0040B706
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseBuildingLevelUpRequest other)
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

		// Token: 0x0601BE36 RID: 114230 RVA: 0x0040D537 File Offset: 0x0040B737
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BE37 RID: 114231 RVA: 0x0040D540 File Offset: 0x0040B740
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

		// Token: 0x0400A1C5 RID: 41413
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A1C6 RID: 41414
		public const int IdFieldNumber = 6;

		// Token: 0x0400A1C7 RID: 41415
		private int id_;
	}
}
