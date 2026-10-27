using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000964 RID: 2404
	[NetMessage(EMessageId.LordGymReadRequest)]
	public sealed class LordGymReadRequest : IMessage<LordGymReadRequest>, IMessage, IEquatable<LordGymReadRequest>, IDeepCloneable<LordGymReadRequest>, IBufferMessage
	{
		// Token: 0x0600D3CE RID: 54222 RVA: 0x001F35CC File Offset: 0x001F17CC
		[NullableContext(1)]
		public static LordGymReadRequest Create()
		{
			return new LordGymReadRequest();
		}

		// Token: 0x17002AE9 RID: 10985
		// (get) Token: 0x0600D3CF RID: 54223 RVA: 0x001F35D3 File Offset: 0x001F17D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002AEA RID: 10986
		// (get) Token: 0x0600D3D0 RID: 54224 RVA: 0x001F35D6 File Offset: 0x001F17D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LordGymReadRequest.Descriptor;
			}
		}

		// Token: 0x0600D3D1 RID: 54225 RVA: 0x001F35DD File Offset: 0x001F17DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LordGymReadRequest()
		{
		}

		// Token: 0x0600D3D2 RID: 54226 RVA: 0x001F35E5 File Offset: 0x001F17E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LordGymReadRequest(LordGymReadRequest other) : this()
		{
			this.loadGymId_ = other.loadGymId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D3D3 RID: 54227 RVA: 0x001F360A File Offset: 0x001F180A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LordGymReadRequest Clone()
		{
			return new LordGymReadRequest(this);
		}

		// Token: 0x17002AEB RID: 10987
		// (get) Token: 0x0600D3D4 RID: 54228 RVA: 0x001F3612 File Offset: 0x001F1812
		// (set) Token: 0x0600D3D5 RID: 54229 RVA: 0x001F361A File Offset: 0x001F181A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LoadGymId
		{
			get
			{
				return this.loadGymId_;
			}
			set
			{
				this.loadGymId_ = value;
			}
		}

		// Token: 0x0600D3D6 RID: 54230 RVA: 0x001F3623 File Offset: 0x001F1823
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LordGymReadRequest);
		}

		// Token: 0x0600D3D7 RID: 54231 RVA: 0x001F3631 File Offset: 0x001F1831
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LordGymReadRequest other)
		{
			return other != null && (other == this || (this.LoadGymId == other.LoadGymId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D3D8 RID: 54232 RVA: 0x001F3660 File Offset: 0x001F1860
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LoadGymId != 0)
			{
				num ^= this.LoadGymId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D3D9 RID: 54233 RVA: 0x001F369F File Offset: 0x001F189F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D3DA RID: 54234 RVA: 0x001F36AC File Offset: 0x001F18AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D3DB RID: 54235 RVA: 0x001F36B5 File Offset: 0x001F18B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LoadGymId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.LoadGymId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D3DC RID: 54236 RVA: 0x001F36E8 File Offset: 0x001F18E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LoadGymId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LoadGymId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D3DD RID: 54237 RVA: 0x001F3726 File Offset: 0x001F1926
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LordGymReadRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LoadGymId != 0)
			{
				this.LoadGymId = other.LoadGymId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D3DE RID: 54238 RVA: 0x001F3757 File Offset: 0x001F1957
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D3DF RID: 54239 RVA: 0x001F3760 File Offset: 0x001F1960
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
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.LoadGymId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005901 RID: 22785
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005902 RID: 22786
		public const int LoadGymIdFieldNumber = 2;

		// Token: 0x04005903 RID: 22787
		private int loadGymId_;
	}
}
