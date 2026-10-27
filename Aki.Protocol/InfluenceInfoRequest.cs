using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007CF RID: 1999
	[NetMessage(EMessageId.InfluenceInfoRequest)]
	public sealed class InfluenceInfoRequest : IMessage<InfluenceInfoRequest>, IMessage, IEquatable<InfluenceInfoRequest>, IDeepCloneable<InfluenceInfoRequest>, IBufferMessage
	{
		// Token: 0x0600B3BC RID: 46012 RVA: 0x001AE21D File Offset: 0x001AC41D
		[NullableContext(1)]
		public static InfluenceInfoRequest Create()
		{
			return new InfluenceInfoRequest();
		}

		// Token: 0x17002446 RID: 9286
		// (get) Token: 0x0600B3BD RID: 46013 RVA: 0x001AE224 File Offset: 0x001AC424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002447 RID: 9287
		// (get) Token: 0x0600B3BE RID: 46014 RVA: 0x001AE227 File Offset: 0x001AC427
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfluenceInfoRequest.Descriptor;
			}
		}

		// Token: 0x0600B3BF RID: 46015 RVA: 0x001AE22E File Offset: 0x001AC42E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfluenceInfoRequest()
		{
		}

		// Token: 0x0600B3C0 RID: 46016 RVA: 0x001AE236 File Offset: 0x001AC436
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfluenceInfoRequest(InfluenceInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B3C1 RID: 46017 RVA: 0x001AE24F File Offset: 0x001AC44F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfluenceInfoRequest Clone()
		{
			return new InfluenceInfoRequest(this);
		}

		// Token: 0x0600B3C2 RID: 46018 RVA: 0x001AE257 File Offset: 0x001AC457
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfluenceInfoRequest);
		}

		// Token: 0x0600B3C3 RID: 46019 RVA: 0x001AE265 File Offset: 0x001AC465
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfluenceInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600B3C4 RID: 46020 RVA: 0x001AE284 File Offset: 0x001AC484
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

		// Token: 0x0600B3C5 RID: 46021 RVA: 0x001AE2AA File Offset: 0x001AC4AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B3C6 RID: 46022 RVA: 0x001AE2B7 File Offset: 0x001AC4B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B3C7 RID: 46023 RVA: 0x001AE2C0 File Offset: 0x001AC4C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B3C8 RID: 46024 RVA: 0x001AE2D8 File Offset: 0x001AC4D8
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

		// Token: 0x0600B3C9 RID: 46025 RVA: 0x001AE2FE File Offset: 0x001AC4FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfluenceInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B3CA RID: 46026 RVA: 0x001AE31B File Offset: 0x001AC51B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B3CB RID: 46027 RVA: 0x001AE324 File Offset: 0x001AC524
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

		// Token: 0x04005024 RID: 20516
		private UnknownFieldSet _unknownFields;
	}
}
