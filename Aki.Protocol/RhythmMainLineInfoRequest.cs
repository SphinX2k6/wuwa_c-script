using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F3B RID: 3899
	[NetMessage(EMessageId.RhythmMainLineInfoRequest)]
	public sealed class RhythmMainLineInfoRequest : IMessage<RhythmMainLineInfoRequest>, IMessage, IEquatable<RhythmMainLineInfoRequest>, IDeepCloneable<RhythmMainLineInfoRequest>, IBufferMessage
	{
		// Token: 0x06014DCC RID: 85452 RVA: 0x00306CB1 File Offset: 0x00304EB1
		[NullableContext(1)]
		public static RhythmMainLineInfoRequest Create()
		{
			return new RhythmMainLineInfoRequest();
		}

		// Token: 0x1700455D RID: 17757
		// (get) Token: 0x06014DCD RID: 85453 RVA: 0x00306CB8 File Offset: 0x00304EB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700455E RID: 17758
		// (get) Token: 0x06014DCE RID: 85454 RVA: 0x00306CBB File Offset: 0x00304EBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RhythmMainLineInfoRequest.Descriptor;
			}
		}

		// Token: 0x06014DCF RID: 85455 RVA: 0x00306CC2 File Offset: 0x00304EC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmMainLineInfoRequest()
		{
		}

		// Token: 0x06014DD0 RID: 85456 RVA: 0x00306CCA File Offset: 0x00304ECA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmMainLineInfoRequest(RhythmMainLineInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014DD1 RID: 85457 RVA: 0x00306CE3 File Offset: 0x00304EE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmMainLineInfoRequest Clone()
		{
			return new RhythmMainLineInfoRequest(this);
		}

		// Token: 0x06014DD2 RID: 85458 RVA: 0x00306CEB File Offset: 0x00304EEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RhythmMainLineInfoRequest);
		}

		// Token: 0x06014DD3 RID: 85459 RVA: 0x00306CF9 File Offset: 0x00304EF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RhythmMainLineInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06014DD4 RID: 85460 RVA: 0x00306D18 File Offset: 0x00304F18
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

		// Token: 0x06014DD5 RID: 85461 RVA: 0x00306D3E File Offset: 0x00304F3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014DD6 RID: 85462 RVA: 0x00306D4B File Offset: 0x00304F4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014DD7 RID: 85463 RVA: 0x00306D54 File Offset: 0x00304F54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014DD8 RID: 85464 RVA: 0x00306D6C File Offset: 0x00304F6C
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

		// Token: 0x06014DD9 RID: 85465 RVA: 0x00306D92 File Offset: 0x00304F92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RhythmMainLineInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014DDA RID: 85466 RVA: 0x00306DAF File Offset: 0x00304FAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014DDB RID: 85467 RVA: 0x00306DB8 File Offset: 0x00304FB8
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

		// Token: 0x04007DDC RID: 32220
		private UnknownFieldSet _unknownFields;
	}
}
