using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200010A RID: 266
	[NetMessage(EMessageId.ApplySceneClientEntityIncIdRequest)]
	public sealed class ApplySceneClientEntityIncIdRequest : IMessage<ApplySceneClientEntityIncIdRequest>, IMessage, IEquatable<ApplySceneClientEntityIncIdRequest>, IDeepCloneable<ApplySceneClientEntityIncIdRequest>, IBufferMessage
	{
		// Token: 0x0600253F RID: 9535 RVA: 0x00063A3D File Offset: 0x00061C3D
		[NullableContext(1)]
		public static ApplySceneClientEntityIncIdRequest Create()
		{
			return new ApplySceneClientEntityIncIdRequest();
		}

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x06002540 RID: 9536 RVA: 0x00063A44 File Offset: 0x00061C44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x06002541 RID: 9537 RVA: 0x00063A47 File Offset: 0x00061C47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ApplySceneClientEntityIncIdRequest.Descriptor;
			}
		}

		// Token: 0x06002542 RID: 9538 RVA: 0x00063A4E File Offset: 0x00061C4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplySceneClientEntityIncIdRequest()
		{
		}

		// Token: 0x06002543 RID: 9539 RVA: 0x00063A61 File Offset: 0x00061C61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplySceneClientEntityIncIdRequest(ApplySceneClientEntityIncIdRequest other) : this()
		{
			this.entityConfigId_ = other.entityConfigId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002544 RID: 9540 RVA: 0x00063A8B File Offset: 0x00061C8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplySceneClientEntityIncIdRequest Clone()
		{
			return new ApplySceneClientEntityIncIdRequest(this);
		}

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x06002545 RID: 9541 RVA: 0x00063A93 File Offset: 0x00061C93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> EntityConfigId
		{
			get
			{
				return this.entityConfigId_;
			}
		}

		// Token: 0x06002546 RID: 9542 RVA: 0x00063A9B File Offset: 0x00061C9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ApplySceneClientEntityIncIdRequest);
		}

		// Token: 0x06002547 RID: 9543 RVA: 0x00063AA9 File Offset: 0x00061CA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ApplySceneClientEntityIncIdRequest other)
		{
			return other != null && (other == this || (this.entityConfigId_.Equals(other.entityConfigId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002548 RID: 9544 RVA: 0x00063ADC File Offset: 0x00061CDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.entityConfigId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002549 RID: 9545 RVA: 0x00063B10 File Offset: 0x00061D10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600254A RID: 9546 RVA: 0x00063B1D File Offset: 0x00061D1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600254B RID: 9547 RVA: 0x00063B26 File Offset: 0x00061D26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.entityConfigId_.WriteTo(ref output, ApplySceneClientEntityIncIdRequest._repeated_entityConfigId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600254C RID: 9548 RVA: 0x00063B50 File Offset: 0x00061D50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.entityConfigId_.CalculateSize(ApplySceneClientEntityIncIdRequest._repeated_entityConfigId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600254D RID: 9549 RVA: 0x00063B89 File Offset: 0x00061D89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ApplySceneClientEntityIncIdRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.entityConfigId_.Add(other.entityConfigId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600254E RID: 9550 RVA: 0x00063BB7 File Offset: 0x00061DB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600254F RID: 9551 RVA: 0x00063BC0 File Offset: 0x00061DC0
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
				if (num != 64U && num != 66U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.entityConfigId_.AddEntriesFrom(ref input, ApplySceneClientEntityIncIdRequest._repeated_entityConfigId_codec);
				}
			}
		}

		// Token: 0x04002602 RID: 9730
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002603 RID: 9731
		public const int EntityConfigIdFieldNumber = 8;

		// Token: 0x04002604 RID: 9732
		private static readonly FieldCodec<int> _repeated_entityConfigId_codec = FieldCodec.ForInt32(66U);

		// Token: 0x04002605 RID: 9733
		private readonly RepeatedField<int> entityConfigId_ = new RepeatedField<int>();
	}
}
