using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.CombatMessage
{
	// Token: 0x02001684 RID: 5764
	[NetMessage(EMessageId.CombatMessagePostInfoResponse)]
	public sealed class CombatMessagePostInfoResponse : IMessage<CombatMessagePostInfoResponse>, IMessage, IEquatable<CombatMessagePostInfoResponse>, IDeepCloneable<CombatMessagePostInfoResponse>, IBufferMessage
	{
		// Token: 0x0601CBE1 RID: 117729 RVA: 0x00425E95 File Offset: 0x00424095
		[NullableContext(1)]
		public static CombatMessagePostInfoResponse Create()
		{
			return new CombatMessagePostInfoResponse();
		}

		// Token: 0x170060DB RID: 24795
		// (get) Token: 0x0601CBE2 RID: 117730 RVA: 0x00425E9C File Offset: 0x0042409C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170060DC RID: 24796
		// (get) Token: 0x0601CBE3 RID: 117731 RVA: 0x00425E9F File Offset: 0x0042409F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CombatMessagePostInfoResponse.Descriptor;
			}
		}

		// Token: 0x0601CBE4 RID: 117732 RVA: 0x00425EA6 File Offset: 0x004240A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatMessagePostInfoResponse()
		{
		}

		// Token: 0x0601CBE5 RID: 117733 RVA: 0x00425EB9 File Offset: 0x004240B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatMessagePostInfoResponse(CombatMessagePostInfoResponse other) : this()
		{
			this.postInfo_ = other.postInfo_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CBE6 RID: 117734 RVA: 0x00425EDE File Offset: 0x004240DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatMessagePostInfoResponse Clone()
		{
			return new CombatMessagePostInfoResponse(this);
		}

		// Token: 0x170060DD RID: 24797
		// (get) Token: 0x0601CBE7 RID: 117735 RVA: 0x00425EE6 File Offset: 0x004240E6
		// (set) Token: 0x0601CBE8 RID: 117736 RVA: 0x00425EEE File Offset: 0x004240EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string PostInfo
		{
			get
			{
				return this.postInfo_;
			}
			set
			{
				this.postInfo_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x0601CBE9 RID: 117737 RVA: 0x00425F01 File Offset: 0x00424101
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CombatMessagePostInfoResponse);
		}

		// Token: 0x0601CBEA RID: 117738 RVA: 0x00425F0F File Offset: 0x0042410F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CombatMessagePostInfoResponse other)
		{
			return other != null && (other == this || (!(this.PostInfo != other.PostInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CBEB RID: 117739 RVA: 0x00425F44 File Offset: 0x00424144
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PostInfo.Length != 0)
			{
				num ^= this.PostInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601CBEC RID: 117740 RVA: 0x00425F85 File Offset: 0x00424185
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CBED RID: 117741 RVA: 0x00425F92 File Offset: 0x00424192
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CBEE RID: 117742 RVA: 0x00425F9B File Offset: 0x0042419B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PostInfo.Length != 0)
			{
				output.WriteRawTag(50);
				output.WriteString(this.PostInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CBEF RID: 117743 RVA: 0x00425FD4 File Offset: 0x004241D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PostInfo.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.PostInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601CBF0 RID: 117744 RVA: 0x00426017 File Offset: 0x00424217
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CombatMessagePostInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PostInfo.Length != 0)
			{
				this.PostInfo = other.PostInfo;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601CBF1 RID: 117745 RVA: 0x0042604D File Offset: 0x0042424D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CBF2 RID: 117746 RVA: 0x00426058 File Offset: 0x00424258
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
				if (num != 50U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.PostInfo = input.ReadString();
				}
			}
		}

		// Token: 0x0400C20E RID: 49678
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C20F RID: 49679
		public const int PostInfoFieldNumber = 6;

		// Token: 0x0400C210 RID: 49680
		private string postInfo_ = "";
	}
}
