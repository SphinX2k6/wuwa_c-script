using System;

// Token: 0x0200006B RID: 107
public enum EHttpCode
{
	// Token: 0x04000266 RID: 614
	Continue = 100,
	// Token: 0x04000267 RID: 615
	SwitchingProtocols,
	// Token: 0x04000268 RID: 616
	Processing,
	// Token: 0x04000269 RID: 617
	OK = 200,
	// Token: 0x0400026A RID: 618
	Created,
	// Token: 0x0400026B RID: 619
	Accepted,
	// Token: 0x0400026C RID: 620
	NonAuthoritativeInformation,
	// Token: 0x0400026D RID: 621
	NoContent,
	// Token: 0x0400026E RID: 622
	ResetContent,
	// Token: 0x0400026F RID: 623
	PartialContent,
	// Token: 0x04000270 RID: 624
	MultiStatus,
	// Token: 0x04000271 RID: 625
	MultipleChoices = 300,
	// Token: 0x04000272 RID: 626
	MovedPermanently,
	// Token: 0x04000273 RID: 627
	MoveTemporarily,
	// Token: 0x04000274 RID: 628
	SeeOther,
	// Token: 0x04000275 RID: 629
	NotModified,
	// Token: 0x04000276 RID: 630
	UseProxy,
	// Token: 0x04000277 RID: 631
	SwitchProxy,
	// Token: 0x04000278 RID: 632
	TemporaryRedirect,
	// Token: 0x04000279 RID: 633
	BadRequest = 400,
	// Token: 0x0400027A RID: 634
	Unauthorized,
	// Token: 0x0400027B RID: 635
	PaymentRequired,
	// Token: 0x0400027C RID: 636
	Forbidden,
	// Token: 0x0400027D RID: 637
	NotFound,
	// Token: 0x0400027E RID: 638
	MethodNotAllowed,
	// Token: 0x0400027F RID: 639
	NotAcceptable,
	// Token: 0x04000280 RID: 640
	ProxyAuthenticationRequired,
	// Token: 0x04000281 RID: 641
	RequestTimeout,
	// Token: 0x04000282 RID: 642
	Conflict,
	// Token: 0x04000283 RID: 643
	Gone,
	// Token: 0x04000284 RID: 644
	LengthRequired,
	// Token: 0x04000285 RID: 645
	PreconditionFailed,
	// Token: 0x04000286 RID: 646
	RequestEntityTooLarge,
	// Token: 0x04000287 RID: 647
	RequestURITooLong,
	// Token: 0x04000288 RID: 648
	UnsupportedMediaType,
	// Token: 0x04000289 RID: 649
	RequestedRangeNotSatisfiable,
	// Token: 0x0400028A RID: 650
	ExpectationFailed,
	// Token: 0x0400028B RID: 651
	ImATeapot,
	// Token: 0x0400028C RID: 652
	MisdirectedRequest = 421,
	// Token: 0x0400028D RID: 653
	UnprocessableEntity,
	// Token: 0x0400028E RID: 654
	Locked,
	// Token: 0x0400028F RID: 655
	FailedDependency,
	// Token: 0x04000290 RID: 656
	TooEarly,
	// Token: 0x04000291 RID: 657
	UpgradeRequired,
	// Token: 0x04000292 RID: 658
	RetryWith = 449,
	// Token: 0x04000293 RID: 659
	UnavailableForLegalReasons = 451,
	// Token: 0x04000294 RID: 660
	InternalServerError = 500,
	// Token: 0x04000295 RID: 661
	NotImplemented,
	// Token: 0x04000296 RID: 662
	BadGateway,
	// Token: 0x04000297 RID: 663
	ServiceUnavailable,
	// Token: 0x04000298 RID: 664
	GatewayTimeout,
	// Token: 0x04000299 RID: 665
	HTTPVersionNotSupported,
	// Token: 0x0400029A RID: 666
	VariantAlsoNegotiates,
	// Token: 0x0400029B RID: 667
	InsufficientStorage,
	// Token: 0x0400029C RID: 668
	BandwidthLimitExceeded = 509,
	// Token: 0x0400029D RID: 669
	NotExtended,
	// Token: 0x0400029E RID: 670
	UnparseableResponseHeaders = 600
}
