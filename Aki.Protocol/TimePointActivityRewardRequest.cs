using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013EE RID: 5102
	[NetMessage(EMessageId.TimePointActivityRewardRequest)]
	public sealed class TimePointActivityRewardRequest : IMessage<TimePointActivityRewardRequest>, IMessage, IEquatable<TimePointActivityRewardRequest>, IDeepCloneable<TimePointActivityRewardRequest>, IBufferMessage
	{
		// Token: 0x0601B22A RID: 111146 RVA: 0x003F3045 File Offset: 0x003F1245
		[NullableContext(1)]
		public static TimePointActivityRewardRequest Create()
		{
			return new TimePointActivityRewardRequest();
		}

		// Token: 0x17005BE1 RID: 23521
		// (get) Token: 0x0601B22B RID: 111147 RVA: 0x003F304C File Offset: 0x003F124C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005BE2 RID: 23522
		// (get) Token: 0x0601B22C RID: 111148 RVA: 0x003F304F File Offset: 0x003F124F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TimePointActivityRewardRequest.Descriptor;
			}
		}

		// Token: 0x0601B22D RID: 111149 RVA: 0x003F3056 File Offset: 0x003F1256
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimePointActivityRewardRequest()
		{
		}

		// Token: 0x0601B22E RID: 111150 RVA: 0x003F305E File Offset: 0x003F125E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimePointActivityRewardRequest(TimePointActivityRewardRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B22F RID: 111151 RVA: 0x003F3083 File Offset: 0x003F1283
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimePointActivityRewardRequest Clone()
		{
			return new TimePointActivityRewardRequest(this);
		}

		// Token: 0x17005BE3 RID: 23523
		// (get) Token: 0x0601B230 RID: 111152 RVA: 0x003F308B File Offset: 0x003F128B
		// (set) Token: 0x0601B231 RID: 111153 RVA: 0x003F3093 File Offset: 0x003F1293
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

		// Token: 0x0601B232 RID: 111154 RVA: 0x003F309C File Offset: 0x003F129C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TimePointActivityRewardRequest);
		}

		// Token: 0x0601B233 RID: 111155 RVA: 0x003F30AA File Offset: 0x003F12AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TimePointActivityRewardRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B234 RID: 111156 RVA: 0x003F30D8 File Offset: 0x003F12D8
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

		// Token: 0x0601B235 RID: 111157 RVA: 0x003F3117 File Offset: 0x003F1317
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B236 RID: 111158 RVA: 0x003F3124 File Offset: 0x003F1324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B237 RID: 111159 RVA: 0x003F312D File Offset: 0x003F132D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B238 RID: 111160 RVA: 0x003F3160 File Offset: 0x003F1360
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

		// Token: 0x0601B239 RID: 111161 RVA: 0x003F319E File Offset: 0x003F139E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TimePointActivityRewardRequest other)
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

		// Token: 0x0601B23A RID: 111162 RVA: 0x003F31CF File Offset: 0x003F13CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B23B RID: 111163 RVA: 0x003F31D8 File Offset: 0x003F13D8
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
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009E5D RID: 40541
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009E5E RID: 40542
		public const int IdFieldNumber = 2;

		// Token: 0x04009E5F RID: 40543
		private int id_;
	}
}
